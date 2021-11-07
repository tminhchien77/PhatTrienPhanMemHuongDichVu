using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Api.BankServices
{
    public interface IBankService
    {
        int GetBalance(string idTaiKhoan, decimal payment);
        Task<int> Pay(string idSrcAcc, string idDesAcc, string pass, decimal payment);
    }
}
