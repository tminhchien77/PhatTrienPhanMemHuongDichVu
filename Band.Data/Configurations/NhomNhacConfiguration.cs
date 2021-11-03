using Band.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Band.Data.Configurations
{
    internal class NhomNhacConfiguration : IEntityTypeConfiguration<NhomNhac>
    {
        public void Configure(EntityTypeBuilder<NhomNhac> builder)
        {
            builder.ToTable("NHOMNHAC");
            builder.HasKey(x => x.TenNhom);
            builder.Property(x => x.DebutDate).HasColumnType("date");
            builder.Property(x => x.CongTy).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ChiTiet).HasColumnType("text").IsRequired(false);
            builder.Property(x => x.Spotify).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.AppleMusic).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Youtube).HasMaxLength(50).IsRequired(false);


        }
    }
}