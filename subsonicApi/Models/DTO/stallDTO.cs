public class StallDTO{
    public int Id { get; set; }
    public int EspacioId { get; set; }
    public string Nombre { get; set; }
    public string Info { get; set; }
    public virtual SpaceDTO Espacio { get; set; }
    public virtual List<StallTypeDTO> Tipos { get; set; }
}