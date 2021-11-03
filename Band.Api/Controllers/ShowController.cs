using Band.Api.Catalog.LoaiVeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Band.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly ILoaiVeService _loaiVeService;
        public ShowController(ILoaiVeService loaiVeService)
        {
            _loaiVeService = loaiVeService;
        }
        [HttpGet("loai-ve")]
        public async Task<IActionResult> GetAllLoaiVe()
        {
            var dsLoaiVe = _loaiVeService.GetAll();
            return Ok(dsLoaiVe);
        }


    }
}
