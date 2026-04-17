using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace subsonicApi.Data
{
    public class StallTypeConfiguration : IEntityTypeConfiguration<StallDTO>
    {
        public void Configure(EntityTypeBuilder<StallDTO> builder)
        {
            builder.ToTable("puesto").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.EspacioId).HasColumnName("espacio_id");
            builder.Property(x => x.Nombre).HasColumnName("nombre");
            builder.Property(x => x.Info).HasColumnName("info");

            builder.HasOne(x => x.Espacio)
                .WithOne(x => x.Id)
                .HasForeignKey(x => x.EspacioId);
        }
    }
}