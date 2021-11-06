using Band.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Band.Model
{
    public class VeConfiguration : IEntityTypeConfiguration<Ve>
    {
        public void Configure(EntityTypeBuilder<Ve> builder)
        {
            builder.ToTable("VE");
            builder.HasKey(x => x.IdVe);
            builder.Property(x => x.IdVe).UseIdentityColumn();
            builder.Property(x => x.MaSoVe).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.HasOne(x => x.HoaDon).WithMany(x => x.DsVe).HasForeignKey(x => x.IDHoaDon);
            builder.HasIndex(u => u.MaSoVe).IsUnique();
        }
    }
}