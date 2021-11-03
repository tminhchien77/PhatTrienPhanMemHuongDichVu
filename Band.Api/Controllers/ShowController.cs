using Band.Api.Catalog.LoaiVeServices;
using Band.Api.Catalog.ShowServices;
using Band.ViewModels.Catalog.Show;
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
        private readonly IManageShowService _manageShowService;
        public ShowController(ILoaiVeService loaiVeService, IManageShowService manageShowService)
        {
            _loaiVeService = loaiVeService;
            _manageShowService = manageShowService;
        }
        [HttpGet("loai-ve")]
        public async Task<IActionResult> GetAllLoaiVe()
        {
            var dsLoaiVe = _loaiVeService.GetAll();
            return Ok(dsLoaiVe);
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var dsShow = _manageShowService.GetAll();
            return Ok(dsShow);
        }
        [HttpGet("all-img")]
        public async Task<IActionResult> GetAllImgById(int idShow)
        {
            var result = _manageShowService.GetAllImgById(idShow);
            return Ok(result);
        }
        [HttpPost("adding-images")]
        public async Task<IActionResult> AddingImages(ImagesShowAddRequest request)
        {
            var result = await _manageShowService.AddingImages(request);
            if (result == 0)
                return BadRequest();
            return Ok(result);
        }

    }
}
