public class ArtistDTO{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public string Nombre { get; set; }
    public virtual EventDTO Evento { get; set; }
}