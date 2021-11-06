using Band.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Band.Api.Catalog.BankServices
{
    public class BankService : IBankService
    {
        private readonly BandDbContext _context;

        public BankService(BandDbContext context)
        {
            _context = context;
        }
        public Task<int> GetBalance(string idTaiKhoan, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
