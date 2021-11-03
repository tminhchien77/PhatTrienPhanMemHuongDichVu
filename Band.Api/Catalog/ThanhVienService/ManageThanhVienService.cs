using Band.Data.EF;
using Band.Data.Entities;
using Band.ViewModels.Catalog.Anh;
using Band.ViewModels.Catalog.ThanhVien;
using Band.ViewModels.Catalog.VaiTro;
using Band.ViewModels.Common;
using Band.ViewModels.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Band.Api.Catalog.ThanhVienService
{
    public class ManageThanhVienService : IManageThanhVienService
    {
        private readonly BandDbContext _context;


        public ManageThanhVienService(BandDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ThanhVienCreateRequest request)
        {

            //Thêm hình ảnh vào bảng hình ảnh trước
            List<HinhAnh> dsAvatar = new List<HinhAnh>();
            /*List<ThanhVienVsHinhAnh> dsThanhVienVsHinhAnh = new List<ThanhVienVsHinhAnh>();*/
            foreach(byte[] img in request.DsAvatar)
            {
                dsAvatar.Add(new HinhAnh()
                {
                    Anh = img,
                    IdLoai= (int)ImageType.AVATAR_MEM
                }); 
            }
            List<HinhAnh> dsCover = new List<HinhAnh>();
            foreach (byte[] img in request.DsCover)
            {
                dsCover.Add(new HinhAnh()
                {
                    Anh = img,
                    IdLoai = (int)ImageType.COVER_MEM
                });
            }

            List<VaiTro> dsVaiTro = new List<VaiTro>();
            foreach (var idVaiTro in request.DsIdVaiTro)
            {
                dsVaiTro.Add(await _context.VaiTroDbo.FindAsync(idVaiTro));
            }
/*            List<VaiTro> dsVaiTroMoi = new List<VaiTro>();
            foreach (var vaiTro in request.DsTenVaiTro)
            {
                dsVaiTroMoi.Add(new VaiTro()
                {
                    TenVaiTro=vaiTro
                });
            }*/

            var thanhVien = new ThanhVien()
            {
                NgheDanh = request.NgheDanh,
                TenKhaiSinh = request.TenKhaiSinh,
                NgaySinh = request.NgaySinh,
                QuocTich = request.QuocTich,
                DebutDate = request.DebutDate,
                TieuSu = request.TieuSu,
                Instagram = request.Instagram,
                Twitter = request.Twitter,
                DsThanhVienVsHinhAnh = new List<ThanhVienVsHinhAnh>(),
                DsThanhVienVsVaiTro=new List<ThanhVienVsVaiTro>()
                /*DsThanhVienVsHinhAnh = dsThanhVienVsHinhAnh*/
            };
            
            foreach(var img in dsAvatar)
            {
                ThanhVienVsHinhAnh thanhVienVsHinhAnh = new ThanhVienVsHinhAnh()
                {
                    HinhAnh = img,
                    ThanhVien = thanhVien
                };
                thanhVien.DsThanhVienVsHinhAnh.Add(thanhVienVsHinhAnh);
            }
            foreach (var img in dsCover)
            {
                ThanhVienVsHinhAnh thanhVienVsHinhAnh = new ThanhVienVsHinhAnh()
                {
                    HinhAnh = img,
                    ThanhVien = thanhVien
                };
                thanhVien.DsThanhVienVsHinhAnh.Add(thanhVienVsHinhAnh);
            }
            foreach (var vaiTro in dsVaiTro)
            {
                ThanhVienVsVaiTro thanhVienVsVaiTro = new ThanhVienVsVaiTro()
                {
                    ThanhVien=thanhVien,
                    VaiTro=vaiTro
                };
                thanhVien.DsThanhVienVsVaiTro.Add(thanhVienVsVaiTro);
            }

            /*await _context.VaiTroDbo.AddRangeAsync(dsVaiTroMoi);*/
            await _context.HinhAnhDbo.AddRangeAsync(dsAvatar);
            await _context.HinhAnhDbo.AddRangeAsync(dsCover);
            await _context.ThanhVienDbo.AddAsync(thanhVien);
            return await _context.SaveChangesAsync();
        }
        public async Task<ThanhVienViewModel> GetById(int idThanhVien)
        {
            /*var query = from t in _context.ThanhVienDbo
                        join tv in _context.ThanhVienVsVaiTroDbo on t.IdThanhVien equals tv.IdThanhVien
                        join v in _context.VaiTroDbo on tv.IdVaiTro equals v.IdVaiTro
                        join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                        join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                        where t.IdThanhVien.Equals(idThanhVien)
                        select new { t, v.TenVaiTro, a.Anh };
            var data = query.Select(;*/


            var thanhVien = await _context.ThanhVienDbo.FindAsync(idThanhVien);
            var avatarFromDb = await (from t in _context.ThanhVienDbo
                             join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                             join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                             where t.IdThanhVien.Equals(idThanhVien) && a.IdLoai.Equals((int)ImageType.AVATAR_MEM)
                             select a.Anh).FirstOrDefaultAsync();
            var coverFromDb = await (from t in _context.ThanhVienDbo
                                      join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                                      join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                                      where t.IdThanhVien.Equals(idThanhVien) && a.IdLoai.Equals((int)ImageType.COVER_MEM)
                                      select a.Anh).FirstOrDefaultAsync();

            /*var dsHinhAnh = new List<byte[]>();
            foreach (var x in dsHinhAnhFromDb)
            {
                dsHinhAnh.Add(new byte[]()
                {
                    IdVaiTro = x.IdVaiTro,
                    TenVaiTro = x.TenVaiTro
                });
            }*/

            var dsVaiTroFromDb = await (from t in _context.ThanhVienDbo
                                  join tv in _context.ThanhVienVsVaiTroDbo on t.IdThanhVien equals tv.IdThanhVien
                                  join v in _context.VaiTroDbo on tv.IdVaiTro equals v.IdVaiTro
                                  where t.IdThanhVien.Equals(idThanhVien)
                                   select new { v.IdVaiTro, v.TenVaiTro}).ToListAsync();
            var dsVaiTro = new List<VaiTroViewModel>();
            foreach(var x in dsVaiTroFromDb)
            {
                dsVaiTro.Add(new VaiTroViewModel()
                {
                    IdVaiTro = x.IdVaiTro,
                    TenVaiTro = x.TenVaiTro
                });
            }
            ThanhVienViewModel thanhVienVm = new ThanhVienViewModel()
            {
                DebutDate = thanhVien.DebutDate,
                DsVaiTro = dsVaiTro,
                Avatar = avatarFromDb,
                Cover=coverFromDb,
                Instagram = thanhVien.Instagram,
                NgaySinh = thanhVien.NgaySinh,
                NgheDanh = thanhVien.NgheDanh,
                QuocTich = thanhVien.QuocTich,
                TenKhaiSinh = thanhVien.TenKhaiSinh,
                TieuSu = thanhVien.TieuSu,
                Twitter = thanhVien.Twitter
            };
            return thanhVienVm;
        }


        public async Task<int> Delete(int thanhVienId)
        {
            var thanhVien = await _context.ThanhVienDbo.FindAsync(thanhVienId);
            var dsHinhAnhFromDb = await (from t in _context.ThanhVienDbo
                                       join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                                       join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                                       where t.IdThanhVien.Equals(thanhVienId)
                                       select a).ToListAsync();
            
            /*            if (thanhVien == null) throw*/
            _context.ThanhVienDbo.Remove(thanhVien);
            _context.HinhAnhDbo.RemoveRange(dsHinhAnhFromDb);
            return await _context.SaveChangesAsync();
        }

        public async Task<PageResult<ThanhVienViewModel>> GetAllPaging(GetThanhVienPagingRequest request)
        {

            var query = from t in _context.ThanhVienDbo
                        join tv in _context.ThanhVienVsVaiTroDbo on t.IdThanhVien equals tv.IdThanhVien
                        join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                        select t;
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ThanhVienViewModel()
                {
                    NgheDanh = x.NgheDanh,
                    TenKhaiSinh = x.TenKhaiSinh,
                    QuocTich = x.QuocTich,
                    NgaySinh = x.NgaySinh,
                    DebutDate = x.DebutDate,
                    TieuSu = x.TieuSu,
                    Instagram = x.Instagram,
                    Twitter = x.Twitter
                }).ToListAsync()
                ;
            var pageResult = new PageResult<ThanhVienViewModel>()
            {
                TotalRecord = totalRow,
                List = data
            };
            return pageResult;
        }

        public async Task<int> Update(ThanhVienUpdateRequestWithoutVaiTro request)
        {
            var thanhVien = await _context.ThanhVienDbo.FindAsync(request.IdThanhVien);
            thanhVien.NgheDanh = request.NgheDanh;
            thanhVien.DebutDate = request.DebutDate;
            thanhVien.Instagram = request.Instagram;
            thanhVien.NgaySinh = request.NgaySinh;
            thanhVien.QuocTich = request.QuocTich;
            thanhVien.TenKhaiSinh = request.TenKhaiSinh;
            thanhVien.TieuSu = request.TieuSu;
            thanhVien.Twitter = request.Twitter;
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ThanhVienGetAllViewModel>> GetAll()
        {
            var dsThanhVien = await _context.ThanhVienDbo.Select(p => new { p.IdThanhVien, p.NgheDanh }).ToListAsync();
            List<ThanhVienGetAllViewModel> dsThanhVienVm = new List<ThanhVienGetAllViewModel>();
            foreach (var x in dsThanhVien)
            {
                dsThanhVienVm.Add(new ThanhVienGetAllViewModel()
                {
                    IdThanhVien = x.IdThanhVien,
                    NgheDanh = x.NgheDanh
                });
            }
                /*foreach (var x in dsThanhVien)
                {
                    var hinhAnh= await (from t in _context.ThanhVienDbo
                                          join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                                          join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                                          where t.IdThanhVien.Equals(x.IdThanhVien)
                                          select a.Anh).FirstOrDefaultAsync();
                    var dsVaiTro= await (from t in _context.ThanhVienDbo
                                         join tv in _context.ThanhVienVsVaiTroDbo on t.IdThanhVien equals tv.IdThanhVien
                                         join v in _context.VaiTroDbo on tv.IdVaiTro equals v.IdVaiTro
                                         where t.IdThanhVien.Equals(x.IdThanhVien)
                                         select v.TenVaiTro).ToListAsync();
                    dsThanhVienVm.Add(new ThanhVienViewModel()
                    {
                        DebutDate = x.DebutDate,
                        DsVaiTro = dsVaiTro,
                        HinhAnh = hinhAnh,
                        Instagram = x.Instagram,
                        NgaySinh = x.NgaySinh,
                        NgheDanh = x.NgheDanh,
                        QuocTich = x.QuocTich,
                        TenKhaiSinh = x.TenKhaiSinh,
                        TieuSu = x.TieuSu,
                        Twitter = x.Twitter
                    });
                }*/
                return dsThanhVienVm;
        }

        public async Task<int> AddingImages(HinhAnhThanhVienRequest request)
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
            List<ThanhVienVsHinhAnh> dsThanhVienVsHinhAnh = new List<ThanhVienVsHinhAnh>();
            foreach (var img in dsHinhAnh)
            {
                ThanhVienVsHinhAnh thanhVienVsHinhAnh = new ThanhVienVsHinhAnh()
                {
                    HinhAnh = img,
                    IdThanhVien = request.IdThanhVien
                };
                dsThanhVienVsHinhAnh.Add(thanhVienVsHinhAnh);
            }
            await _context.HinhAnhDbo.AddRangeAsync(dsHinhAnh);
            await _context.ThanhVienVsHinhAnhDbo.AddRangeAsync(dsThanhVienVsHinhAnh);
            return await _context.SaveChangesAsync();
        }

        public async Task<NewListOfByteArrayImage> GetAllAvatarById(int idThanhVien)
        {
            var dsHinhAnhFromDb = await(from t in _context.ThanhVienDbo
                                      join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                                      join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                                      where t.IdThanhVien.Equals(idThanhVien) && a.IdLoai.Equals((int)ImageType.AVATAR_MEM)
                                      select a).ToListAsync();
            var result = new NewListOfByteArrayImage();
            foreach(var x in dsHinhAnhFromDb)
            {
                result.Add(new ByteArrayImageObject(x.IdAnh, x.Anh));
            }
            return result;
        }

        public async Task<List<ThanhVienVsHinhAnhViewModel>> GetThanhVienVsHinhAnh()
        {
            var dsThanhVien = await _context.ThanhVienDbo.Select(p => new { p.IdThanhVien, p.NgheDanh }).ToListAsync();

            var dsThanhVienVsHinhAnh = await (from tv in _context.ThanhVienDbo
                                        join th in _context.ThanhVienVsHinhAnhDbo on tv.IdThanhVien equals th.IdThanhVien
                                        join a in _context.HinhAnhDbo on th.IdAnh equals a.IdAnh
                                        select new { tv.IdThanhVien, a.Anh }).ToListAsync();
            var result=new List<ThanhVienVsHinhAnhViewModel>();
            foreach(var x in dsThanhVien)
            {
                var dsHinhAnh = new List<byte[]>();
                foreach (var y in dsThanhVienVsHinhAnh)
                {
                    if (x.IdThanhVien == y.IdThanhVien)
                    {
                        
                        dsHinhAnh.Add(y.Anh);
                    }
                }
                result.Add(new ThanhVienVsHinhAnhViewModel()
                {
                    NgheDanh = x.NgheDanh,
                    DsHinhAnh = dsHinhAnh
                });

            }
            return result;
        }

        public async Task<int> DeleteImages(List<int> listIdAnh)
        {
            foreach(var i in listIdAnh)
            {
                var img = _context.HinhAnhDbo.Where(h => h.IdAnh == i);
                _context.HinhAnhDbo.Remove((HinhAnh)img);
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<NewListOfByteArrayImage> GetAllCoverById(int idThanhVien)
        {
            var dsHinhAnhFromDb = await(from t in _context.ThanhVienDbo
                                        join ta in _context.ThanhVienVsHinhAnhDbo on t.IdThanhVien equals ta.IdThanhVien
                                        join a in _context.HinhAnhDbo on ta.IdAnh equals a.IdAnh
                                        where t.IdThanhVien.Equals(idThanhVien) && a.IdLoai.Equals((int)ImageType.COVER_MEM)
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