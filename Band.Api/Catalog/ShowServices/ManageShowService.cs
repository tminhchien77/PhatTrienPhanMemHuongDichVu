using Band.Data.EF;
using Band.Data.Entities;
using Band.ViewModels.Catalog.Show;
using Band.ViewModels.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Band.Api.Catalog.ShowServices
{
    public class ManageShowService : IManageShowService
    {
        private readonly BandDbContext _context;


        public ManageShowService(BandDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddingImages(ImagesShowAddRequest request)
        {
            List<HinhAnh> dsHinhAnh = new List<HinhAnh>();
            /*List<ThanhVienVsHinhAnh> dsThanhVienVsHinhAnh = new List<ThanhVienVsHinhAnh>();*/
            foreach (byte[] img in request.DsAnh)
            {
                dsHinhAnh.Add(new HinhAnh()
                {
                    Anh = img,
                    IdLoai = request.IdLoai
                });
            }
            List<ShowVsHinhAnh> dsShowVsHinhAnh = new List<ShowVsHinhAnh>();
            foreach (var img in dsHinhAnh)
            {
                ShowVsHinhAnh showVsHinhAnh = new ShowVsHinhAnh()
                {
                    HinhAnh = img,
                    IdShow = request.IdShow
                };
                dsShowVsHinhAnh.Add(showVsHinhAnh);
            }
            await _context.HinhAnhDbo.AddRangeAsync(dsHinhAnh);
            await _context.ShowVsHinhAnhDbo.AddRangeAsync(dsShowVsHinhAnh);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Create(ShowCreateRequest request)
        {
            throw new NotImplementedException();
            /*var show = new Show()
            {
                DiaDiem = request.DiaDiem,
                TenShow = request.TenShow,
                ThoiDiemBieuDien = request.NgayBieuDien.Date.Add(request.GioBieuDien.TimeOfDay),
                ThoiDiemMoBan= request.NgayMoBan.Date.Add(request.GioMoBan.TimeOfDay),
                DsShowVsHinhAnh
            }*/
        }

        public async Task<List<ShowGetAllViewModel>> GetAll()
        {
            var dsShow = await _context.ShowDbo.Select(p => new { p.IdShow, p.TenShow, p.ThoiDiemBieuDien }).ToListAsync();
            List<ShowGetAllViewModel> dsShowVm = new List<ShowGetAllViewModel>();
            foreach (var x in dsShow)
            {
                dsShowVm.Add(new ShowGetAllViewModel()
                {
                    IdShow=x.IdShow,
                    TenShow=x.TenShow,
                    NgayBieuDien=x.ThoiDiemBieuDien.Date
                });
            }
            return dsShowVm;
        }

        public async Task<NewListOfByteArrayImage> GetAllImgById(int idShow)
        {
            var dsHinhAnhFromDb = await(from s in _context.ShowDbo
                                        join sa in _context.ShowVsHinhAnhDbo on s.IdShow equals sa.IdShow
                                        join a in _context.HinhAnhDbo on sa.IdAnh equals a.IdAnh
                                        where s.IdShow.Equals(idShow) && a.IdLoai.Equals((int)ImageType.IMG_SHOW)
                                        select a).ToListAsync();
            var result = new NewListOfByteArrayImage();
            foreach (var x in dsHinhAnhFromDb)
            {
                result.Add(new ByteArrayImageObject(x.IdAnh, x.Anh));
            }
            return result;
        }
    }
}
