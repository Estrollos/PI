using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace subsonicApi.Data
{
    public class BuyTicketTypeConfiguration : IEntityTypeConfiguration<BuyTicketDTO>
    {
        public void Configure(EntityTypeBuilder<BuyTicketDTO> builder)
        {
            builder.ToTable("compra_entrada").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.ClienteId).HasColumnName("cliente_id");
            builder.Property(x => x.EntradaId).HasColumnName("entrada_id");
            builder.Property(x => x.Cantidad).HasColumnName("cantidad");
            builder.Property(x => x.FechaCompra).HasColumnName("fecha_compra");
        }
    }
}