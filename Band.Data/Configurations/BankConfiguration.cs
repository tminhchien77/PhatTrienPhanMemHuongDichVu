using Band.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.Data.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("NGANHANG");
            builder.HasKey(x => x.IdTaiKhoan);
            builder.Property(x => x.IdTaiKhoan).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.SoDu).HasColumnType("numeric").IsRequired();
            builder.Property(x => x.PasswordStored).HasColumnType("varchar").IsRequired().HasColumnName("MatKhau").HasMaxLength(330);//Mật khẩu bản rõ tối đa 8 ký tự
            builder.Ignore(x => x.Password);
        }
    }
}
