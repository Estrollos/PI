using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace subsonicApi.Data
{
    public class ArtistTypeConfiguration : IEntityTypeConfiguration<ArtistDTO>
    {
        public void Configure(EntityTypeBuilder<ArtistDTO> builder)
        {
            builder.ToTable("artista").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.EventoId).HasColumnName("evento_id");
            builder.Property(x => x.Nombre).HasColumnName("nombre");
        }
    }
}