using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace subsonicApi.Data
{
    public class TicketTypeConfiguration : IEntityTypeConfiguration<TicketDTO>
    {
        public void Configure(EntityTypeBuilder<TicketDTO> builder)
        {
            builder.ToTable("entrada").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.EventoId).HasColumnName("evento_id");
            builder.Property(x => x.Stock).HasColumnName("stock");
            builder.Property(x => x.Precio).HasColumnName("precio");
        }
    }
}