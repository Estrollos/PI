public class ProductImageDTO
{
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string Url { get; set; }
    public virtual ProductDTO Producto { get; set; }
}