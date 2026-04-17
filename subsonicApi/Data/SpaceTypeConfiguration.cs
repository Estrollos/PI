using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace subsonicApi.Data
{
    public class SpaceTypeConfiguration : IEntityTypeConfiguration<SpaceDTO>
    {
        public void Configure(EntityTypeBuilder<SpaceDTO> builder)
        {
            builder.ToTable("espacio").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.ClienteId).HasColumnName("cliente_id");
            builder.Property(x => x.Dia).HasColumnName("dia");
            builder.Property(x => x.Escenario).HasColumnName("escenario");
            builder.Property(x => x.Dia).HasColumnName("dia");
            builder.Property(x => x.Precio).HasColumnName("precio");
            builder.Property(x => x.Libre).HasColumnName("libre");
        }
    }
}