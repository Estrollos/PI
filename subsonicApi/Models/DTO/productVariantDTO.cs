using subsonicApi.Enums;

public class ProductVariantDTO{
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string Color { get; set; }
    public SizeEnum Talla { get; set; }
    public int Stock { get; set; }
    public virtual ProductDTO Producto { get; set; }
}