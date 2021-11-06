﻿// <auto-generated />
using System;
using Band.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Band.Data.Migrations
{
    [DbContext(typeof(BandDbContext))]
    [Migration("20211106031933_add-SoLuongBanRa_MaSoVe")]
    partial class addSoLuongBanRa_MaSoVe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Band.Data.Entities.HinhAnh", b =>
                {
                    b.Property<int>("IdAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Anh")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<int>("IdLoai")
                        .HasColumnType("int");

                    b.HasKey("IdAnh");

                    b.HasIndex("IdLoai");

                    b.ToTable("HINHANH");
                });

            modelBuilder.Entity("Band.Data.Entities.HoaDon", b =>
                {
                    b.Property<int>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdShowVsLoaiVe")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdShowVsLoaiVe");

                    b.ToTable("HOADON");
                });

            modelBuilder.Entity("Band.Data.Entities.LoaiAnh", b =>
                {
                    b.Property<int>("IdLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdLoai");

                    b.ToTable("LOAIANH");
                });

            modelBuilder.Entity("Band.Data.Entities.LoaiVe", b =>
                {
                    b.Property<int>("IdLoaiVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChiTiet")
                        .HasColumnType("text");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdLoaiVe");

                    b.ToTable("LOAIVE");
                });

            modelBuilder.Entity("Band.Data.Entities.NhomNhac", b =>
                {
                    b.Property<string>("TenNhom")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppleMusic")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChiTiet")
                        .HasColumnType("text");

                    b.Property<string>("CongTy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DebutDate")
                        .HasColumnType("date");

                    b.Property<string>("Spotify")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Youtube")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TenNhom");

                    b.ToTable("NHOMNHAC");
                });

            modelBuilder.Entity("Band.Data.Entities.Show", b =>
                {
                    b.Property<int>("IdShow")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaDiem")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenShow")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ThoiDiemBieuDien")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiDiemMoBan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdShow");

                    b.ToTable("SHOW");
                });

            modelBuilder.Entity("Band.Data.Entities.ShowVsHinhAnh", b =>
                {
                    b.Property<int>("IdAnh")
                        .HasColumnType("int");

                    b.Property<int>("IdShow")
                        .HasColumnType("int");

                    b.HasKey("IdAnh", "IdShow");

                    b.HasIndex("IdShow");

                    b.ToTable("SHOW_HINHANH");
                });

            modelBuilder.Entity("Band.Data.Entities.ShowVsLoaiVe", b =>
                {
                    b.Property<int>("IdLoaiVe")
                        .HasColumnType("int");

                    b.Property<int>("IdShow")
                        .HasColumnType("int");

                    b.Property<decimal>("Gia")
                        .HasColumnType("numeric");

                    b.Property<int>("IdShowVsLoaiVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoLuongBanRa")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongDaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IdLoaiVe", "IdShow");

                    b.HasIndex("IdShow");

                    b.ToTable("CHITIETVE_SHOW");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVien", b =>
                {
                    b.Property<int>("IdThanhVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DebutDate")
                        .HasColumnType("date");

                    b.Property<string>("Instagram")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("NgheDanh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QuocTich")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenKhaiSinh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TieuSu")
                        .HasColumnType("text");

                    b.Property<string>("Twitter")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdThanhVien");

                    b.ToTable("THANHVIEN");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVienVsHinhAnh", b =>
                {
                    b.Property<int>("IdAnh")
                        .HasColumnType("int");

                    b.Property<int>("IdThanhVien")
                        .HasColumnType("int");

                    b.HasKey("IdAnh", "IdThanhVien");

                    b.HasIndex("IdThanhVien");

                    b.ToTable("ANHTHANHVIEN");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVienVsVaiTro", b =>
                {
                    b.Property<int>("IdThanhVien")
                        .HasColumnType("int");

                    b.Property<int>("IdVaiTro")
                        .HasColumnType("int");

                    b.HasKey("IdThanhVien", "IdVaiTro");

                    b.HasIndex("IdVaiTro");

                    b.ToTable("THANHVIEN_VAITRO");
                });

            modelBuilder.Entity("Band.Data.Entities.VaiTro", b =>
                {
                    b.Property<int>("IdVaiTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdVaiTro");

                    b.HasAlternateKey("TenVaiTro");

                    b.ToTable("VAITRO");
                });

            modelBuilder.Entity("Band.Data.Entities.Ve", b =>
                {
                    b.Property<int>("IdVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDHoaDon")
                        .HasColumnType("int");

                    b.Property<string>("MaSoVe")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdVe");

                    b.HasIndex("IDHoaDon");

                    b.HasIndex("MaSoVe")
                        .IsUnique();

                    b.ToTable("VE");
                });

            modelBuilder.Entity("Band.Data.Entities.HinhAnh", b =>
                {
                    b.HasOne("Band.Data.Entities.LoaiAnh", "LoaiAnh")
                        .WithMany("DsHinhAnh")
                        .HasForeignKey("IdLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiAnh");
                });

            modelBuilder.Entity("Band.Data.Entities.HoaDon", b =>
                {
                    b.HasOne("Band.Data.Entities.ShowVsLoaiVe", "ShowVsLoaiVe")
                        .WithMany("DsHoaDon")
                        .HasForeignKey("IdShowVsLoaiVe")
                        .HasPrincipalKey("IdShowVsLoaiVe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShowVsLoaiVe");
                });

            modelBuilder.Entity("Band.Data.Entities.ShowVsHinhAnh", b =>
                {
                    b.HasOne("Band.Data.Entities.HinhAnh", "HinhAnh")
                        .WithMany("DsShowVsHinhAnh")
                        .HasForeignKey("IdAnh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Band.Data.Entities.Show", "Show")
                        .WithMany("DsShowVsHinhAnh")
                        .HasForeignKey("IdShow")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhAnh");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Band.Data.Entities.ShowVsLoaiVe", b =>
                {
                    b.HasOne("Band.Data.Entities.LoaiVe", "LoaiVe")
                        .WithMany("DsShowVsLoaiVe")
                        .HasForeignKey("IdLoaiVe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Band.Data.Entities.Show", "Show")
                        .WithMany("DsShowVsLoaiVe")
                        .HasForeignKey("IdShow")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiVe");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVienVsHinhAnh", b =>
                {
                    b.HasOne("Band.Data.Entities.HinhAnh", "HinhAnh")
                        .WithMany("DsThanhVienVsHinhAnh")
                        .HasForeignKey("IdAnh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Band.Data.Entities.ThanhVien", "ThanhVien")
                        .WithMany("DsThanhVienVsHinhAnh")
                        .HasForeignKey("IdThanhVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhAnh");

                    b.Navigation("ThanhVien");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVienVsVaiTro", b =>
                {
                    b.HasOne("Band.Data.Entities.ThanhVien", "ThanhVien")
                        .WithMany("DsThanhVienVsVaiTro")
                        .HasForeignKey("IdThanhVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Band.Data.Entities.VaiTro", "VaiTro")
                        .WithMany("DsThanhVienVsVaiTro")
                        .HasForeignKey("IdVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThanhVien");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("Band.Data.Entities.Ve", b =>
                {
                    b.HasOne("Band.Data.Entities.HoaDon", "HoaDon")
                        .WithMany("DsVe")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("Band.Data.Entities.HinhAnh", b =>
                {
                    b.Navigation("DsShowVsHinhAnh");

                    b.Navigation("DsThanhVienVsHinhAnh");
                });

            modelBuilder.Entity("Band.Data.Entities.HoaDon", b =>
                {
                    b.Navigation("DsVe");
                });

            modelBuilder.Entity("Band.Data.Entities.LoaiAnh", b =>
                {
                    b.Navigation("DsHinhAnh");
                });

            modelBuilder.Entity("Band.Data.Entities.LoaiVe", b =>
                {
                    b.Navigation("DsShowVsLoaiVe");
                });

            modelBuilder.Entity("Band.Data.Entities.Show", b =>
                {
                    b.Navigation("DsShowVsHinhAnh");

                    b.Navigation("DsShowVsLoaiVe");
                });

            modelBuilder.Entity("Band.Data.Entities.ShowVsLoaiVe", b =>
                {
                    b.Navigation("DsHoaDon");
                });

            modelBuilder.Entity("Band.Data.Entities.ThanhVien", b =>
                {
                    b.Navigation("DsThanhVienVsHinhAnh");

                    b.Navigation("DsThanhVienVsVaiTro");
                });

            modelBuilder.Entity("Band.Data.Entities.VaiTro", b =>
                {
                    b.Navigation("DsThanhVienVsVaiTro");
                });
#pragma warning restore 612, 618
        }
    }
}