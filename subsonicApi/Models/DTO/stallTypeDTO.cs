using subsonicApi.Enums;

public class StallTypeDTO{
    public int EspacioId { get; set; }
    public StallTypeEnum Tipo { get; set; }
    public virtual SpaceDTO Espacio { get; set; }
}