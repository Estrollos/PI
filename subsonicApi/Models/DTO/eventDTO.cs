using subsonicApi.Enums;

public class EventDTO{
    public int Id { get; set; }
	public StageEnum Escenario { get; set; }
	public DateTime Fecha { get; set; }
	public string Dia { get; set; }
	public HourEnum Hora { get; set; }
	public DayEnum Info { get; set; }
	public int Stock { get; set; }
	public string UrlImg { get; set; }
}