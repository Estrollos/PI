using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace subsonicApi.Data
{
    public class NewTypeConfiguration : IEntityTypeConfiguration<NewsDTO>
    {
        public void Configure(EntityTypeBuilder<NewsDTO> builder)
        {
            builder.ToTable("noticia").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Titulo).HasColumnName("titulo");
            builder.Property(x => x.Subtitulo).HasColumnName("subtitulo");
            builder.Property(x => x.Cuerpo).HasColumnName("cuerpo");
            builder.Property(x => x.UrlImg).HasColumnName("urlImg");
        }
    }
}