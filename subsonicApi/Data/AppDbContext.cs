using Microsoft.EntityFrameworkCore;
using subsonicApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<ArtistDTO> Artists { get; set; }
    public DbSet<BuyProductDTO> BuyProducts { get; set; }
    public DbSet<BuyTicketDTO> BuyTickets { get; set; }
    public DbSet<ClientDTO> Clients { get; set; }
    public DbSet<EventDTO> Events { get; set; }
    public DbSet<MusicDTO> Musics { get; set; }
    public DbSet<NewsDTO> News { get; set; }
    public DbSet<ProductDTO> Products { get; set; }
    public DbSet<ProductImageDTO> ProductImages { get; set; }
    public DbSet<ProductVariantDTO> ProductVariants { get; set; }
    public DbSet<SpaceDTO> Spaces { get; set; }
    public DbSet<StallTypeDTO> StallTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ArtistTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BuyProductTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BuyTicketTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ClientTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EventTypeConfiguration());
        modelBuilder.ApplyConfiguration(new MusicTypeConfiguration());
        modelBuilder.ApplyConfiguration(new NewTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductImgTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductVariantTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SpaceTypeConfiguration());
        modelBuilder.ApplyConfiguration(new StallTypeTypeConfiguration());
    }
}