using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nhom1_Pro.Models;

namespace Nhom1_Pro.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasColumnType("nvarchar(20)");
            builder.Property(x => x.LoaiHinhKm).HasColumnType("nvarchar(20)");
            builder.Property(x => x.PhamVi).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.PhamVi).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.SoLuongTon).HasColumnType("int");
            builder.Property(x => x.SoLanSuDung).HasColumnType("int");
            builder.Property(x => x.MucUuDai).HasColumnType("decimal");
            builder.Property(x => x.NgayBatDau).HasColumnType("datetime");
            builder.Property(x => x.NgayKetThuc).HasColumnType("datetime");
            builder.Property(x => x.TrangThai).HasColumnType("int");
        }
    }
}
