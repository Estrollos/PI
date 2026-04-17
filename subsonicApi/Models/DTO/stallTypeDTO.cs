using subsonicApi.Enums;

public class StallTypeDTO{
    public int PuestoId { get; set; }
    public StallTypeEnum Tipo { get; set; }
    public virtual StallDTO Puesto { get; set; }
}