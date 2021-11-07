﻿using Band.Data.EF;
using Band.Data.Entities;
using Band.ViewModels.Catalog.Show.Public;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static Band.ViewModels.Utilities.SystemConstants;

namespace Band.Api.Catalog.ShowServices
{
    public class PublicShowService : IPublicShowService
    {
        private readonly BandDbContext _context;


        public PublicShowService(BandDbContext context)
        {
            _context = context;
        }
        public async Task<List<PublicShowGetAllVm>> GetAll()
        {
            var dsShow = _context.ShowDbo.Where(p=>p.ThoiDiemBieuDien>DateTime.Now).Select(p => new { p.IdShow, p.TenShow, p.ThoiDiemBieuDien, p.ThoiDiemMoBan }).ToList();
            var dsShowVm = new List<PublicShowGetAllVm>();
            foreach (var x in dsShow)
            {
                var hinhAnhFromDb = (from sa in _context.ShowVsHinhAnhDbo
                                          join a in _context.HinhAnhDbo on sa.IdAnh equals a.IdAnh
                                            where sa.IdShow.Equals(x.IdShow) && a.IdLoai.Equals((int)ImageType.IMG_SHOW)
                                            select a.Anh).FirstOrDefault();
/*                var imgList = new List<byte[]>();
                foreach (var i in dsHinhAnhFromDb)
                {
                    imgList.Add(i);
                }*/
                dsShowVm.Add(new PublicShowGetAllVm()
                {
                    IdShow = x.IdShow,
                    TenShow = x.TenShow,
                    NgayBieuDien = x.ThoiDiemBieuDien.Date,
                    ThoiDiemMoBan=x.ThoiDiemMoBan,
                    HinhAnh= hinhAnhFromDb
                });
            }

            return dsShowVm;
        }

        public async Task<PublicGetByIdShowVm> GetById(int idShow)
        {
            var show = await _context.ShowDbo.FindAsync(idShow);
            var dsHinhAnhFromDb = await (from sa in _context.ShowVsHinhAnhDbo
                                   join a in _context.HinhAnhDbo on sa.IdAnh equals a.IdAnh
                                   where sa.IdShow.Equals(idShow) && a.IdLoai.Equals((int)ImageType.IMG_SHOW)
                                   select a.Anh).ToListAsync();

            var dsChiTietVeFromDb = await (from l in _context.LoaiVeDbo
                                           join sl in _context.ShowVsLoaiVeDbo on l.IdLoaiVe equals sl.IdLoaiVe
                                           where sl.IdShow.Equals(idShow)
                                           select new { l.IdLoaiVe,l.TenLoai, l.ChiTiet, sl.Gia, sl.ConLai }).ToListAsync();

            var dsChiTietVe = new List<PublicChiTietVeVm>();
            foreach (var x in dsChiTietVeFromDb)
            {
                dsChiTietVe.Add(new PublicChiTietVeVm()
                {
                    IdLoaiVe = x.IdLoaiVe,
                    TenLoai=x.TenLoai,
                    ChiTiet =x.ChiTiet,
                    Gia = x.Gia,
                    ConLai=x.ConLai
                });
            }

            var dsHinhAnh = new List<byte[]>();
            foreach (var x in dsHinhAnhFromDb)
            {
                dsHinhAnh.Add(x);
            }

            var showVm = new PublicGetByIdShowVm()
            {
                IdShow=show.IdShow,
                DiaDiem = show.DiaDiem,
                TenShow = show.TenShow,
                ThoiDiemBieuDien = show.ThoiDiemBieuDien,
                ThoiDiemMoBan = show.ThoiDiemMoBan,
                DsHinhAnh=dsHinhAnh,
                DsLoaiVe = dsChiTietVe,
            };
            return showVm;
        }

        public async Task<int> Pay(string idTaiKhoan, string pass, decimal payment, PublicDatVeVm chiTietDatVe)
        {
            var chiTietVe = await _context.ShowVsLoaiVeDbo.FindAsync(chiTietDatVe.IdShow, chiTietDatVe.IdLoaiVe);
            if (chiTietVe.ConLai < chiTietDatVe.SoLuong) return (int)BookingErrorCode.SOLD_OUT;
            else
            {
                string uri = "https://localhost:44323/api/bank/";
                var json = JsonConvert.SerializeObject(new PayingRequest ()
                {
                    idSrcAcc=idTaiKhoan, 
                    idDesAcc= BankAccount, 
                    pass=pass,
                    payment=payment });
                WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = client.UploadString(uri, "PUT", json);
                if (Int32.Parse(response) > 0)//Thanh toán thành công
                {
                    var hoaDon = new HoaDon()
                    {
                        SDT = chiTietDatVe.SDT,
                        SoLuong = chiTietDatVe.SoLuong,
                        IdShowVsLoaiVe = chiTietVe.IdShowVsLoaiVe,
                        NgayGiaoDich = DateTime.Now
                    };
                    var dsve = new List<Ve>();
                    Random ran = new Random();
                    int preRanNumber = -1;
                    for (int i = 0; i < chiTietDatVe.SoLuong; i++)
                    {
                        int getRanNum = ran.Next(100000);
                        while (getRanNum == preRanNumber)
                            getRanNum = ran.Next(100000);
                        dsve.Add(new Ve()
                        {
                            HoaDon = hoaDon,
                            MaSoVe = i.ToString() + hoaDon.NgayGiaoDich.ToString("MMddyyHHmmssfffffff") + $"{getRanNum}".PadLeft(5, '0')
                        });
                        preRanNumber = getRanNum;
                    }
                    chiTietVe.ConLai -= chiTietDatVe.SoLuong;
                    await _context.AddAsync(hoaDon);
                    await _context.AddRangeAsync(dsve);
                    return await _context.SaveChangesAsync();
                }
                
                else return Int32.Parse(response);
            }
        }
    }
}
