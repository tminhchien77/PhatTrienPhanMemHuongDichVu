using Band.ViewModels.Common;
using Bank.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Api.BankServices
{
    public interface IBankService
    {
        Task<int> GetBalance(GetBalanceRequest request);
        Task<int> CreateTransaction(PayingRequest request);
    }
}
