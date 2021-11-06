using Microsoft.OpenApi.Writers;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Band.Data.Entities
{
    public partial class Bank
    {
        public string IdTaiKhoan { get; set; }
        public decimal SoDu { get; set; }
        public virtual string PasswordStored
        {
            get;
            set;
        }

        public string Password
        {
            get { return Decrypt(PasswordStored); }
            set { PasswordStored = Encrypt(value); }
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
