public class TicketDTO
{
    public int Id { get; set; }
	public int EventoId { get; set; }
	public int Stock { get; set; }
	public int Precio { get; set; }
    public virtual EventDTO Evento { get; set; }
}