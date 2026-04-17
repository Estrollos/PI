public class BuyTicketDTO
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int EntradaId { get; set; }
    public int Cantidad { get; set; }
    public DateTime FechaCompra { get; set; }
    public virtual ClientDTO Cliente { get; set; }
    public virtual TicketDTO Entrada { get; set; }
}
