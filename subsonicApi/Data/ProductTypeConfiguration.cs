using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace subsonicApi.Data
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductDTO>
    {
        public void Configure(EntityTypeBuilder<ProductDTO> builder)
        {
            builder.ToTable("producto").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Precio).HasColumnName("precio");
            builder.Property(x => x.Nombre).HasColumnName("nombre");
            builder.Property(x => x.Info).HasColumnName("info");

            builder.HasMany(x => x.Imagenes).WithOne(x => x.Producto).HasForeignKey(x => x.ProductoId);
            builder.HasMany(x => x.Variantes).WithOne(x => x.Producto).HasForeignKey(x => x.ProductoId);
        }
    }
}