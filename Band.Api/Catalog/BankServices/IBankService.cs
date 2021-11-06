using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Band.Api.Catalog.BankServices
{
    public interface IBankService
    {
        Task<int> GetBalance(string idTaiKhoan, string pass);
    }
}
