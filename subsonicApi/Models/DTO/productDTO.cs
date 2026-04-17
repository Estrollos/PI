public class ProductDTO{
    public int Id { get; set; }
    public int Precio { get; set; }
    public string Nombre { get; set; }
    public string Info { get; set; }
    public virtual List<ProductVariantDTO> Variantes { get; set; }
    public virtual List<ProductImageDTO> Imagenes { get; set; }
}