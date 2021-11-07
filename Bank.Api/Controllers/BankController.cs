using Band.ViewModels.Catalog.Show.Public;
using Bank.Api.BankServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBalance(string idTaiKhoan, decimal payment)
        {
            var balance = _bankService.GetBalance(idTaiKhoan, payment);
            return Ok(balance);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBalance(PayingRequest request)
        {
            var result = await _bankService.Pay(request.idSrcAcc, request.idDesAcc, request.pass, request.payment);
            return Ok(result);
        }
    }
}
