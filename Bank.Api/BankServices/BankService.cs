using Band.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Bank.Api.BankServices
{
    public class BankService : IBankService
    {
        private readonly BandDbContext _context;

        public BankService(BandDbContext context)
        {
            _context = context;
        }
        public int GetBalance(string idTaiKhoan, decimal payment)
        {
            var balance = (from n in _context.BankDbo
                           where n.IdTaiKhoan.Equals(idTaiKhoan)
                           select (new { n.SoDu })).FirstOrDefault();
            if (balance == null) return -1;
            else
            {
                if (balance.SoDu < payment) return 0;
                else return 1;
            }


        }

        public async Task<int> Pay(string idSrcAcc, string idDesAcc, string pass, decimal payment)
        {
            var srcAcc = (from n in _context.BankDbo
                          where n.IdTaiKhoan.Equals(idSrcAcc)
                          select n).FirstOrDefault();
            var tmp = Decrypt(srcAcc.PasswordStored);

            if (srcAcc == null || !tmp.Equals(pass)) return (int)BankErrorCode.LOGIN_FAILED;

            var desAcc = (from n in _context.BankDbo
                          where n.IdTaiKhoan.Equals(idDesAcc)
                          select n).FirstOrDefault();
            if (desAcc == null) return (int)BankErrorCode.INCORRECT_DES_ACC; //Sai tài khoản bên nhận
            else
            {
                if (srcAcc.SoDu < payment) return (int)BankErrorCode.BALANCE_NOT_ENOUGH;//Số dư còn lại trong tài khoản không đủ 
                else
                {
                    srcAcc.SoDu -= payment;
                    desAcc.SoDu += payment;
                    return await _context.SaveChangesAsync();
                }
            }

        }
        public string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            //encrypt data
            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);

            //return as base64 string
            return Convert.ToBase64String(encrypted);
        }
        public string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);

            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
