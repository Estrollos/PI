using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace subsonicApi.Data
{
    public class StallTypeTypeConfiguration : IEntityTypeConfiguration<StallTypeDTO>
    {
        public void Configure(EntityTypeBuilder<StallTypeDTO> builder)
        {
            builder.ToTable("puesto_tipo").HasKey(x => new {x.PuestoId, x.Tipo});

            builder.Property(x => x.PuestoId).HasColumnName("puesto_id");
            builder.Property(x => x.Tipo).HasColumnName("tipo");
        }
    }
}