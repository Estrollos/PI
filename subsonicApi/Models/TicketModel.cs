using subsonicApi.Models.DAO.Interfaces;
public class TicketModel
{
    private readonly ITicketDAO _ticketDAO;

    public TicketModel(IDAOFactory factory) {
        _ticketDAO = factory.CreateTicketDAO();
    }

    public async Task<List<TicketDTO>> GetAll()
    {
       return await _ticketDAO.GetAll();
    } 

    public async Task<TicketDTO> GetById(int id){
         var news = await _ticketDAO.GetById(id);
         if (news == null)
            throw new Exception("Noticia no encontrada");
        return news;
    }

    public async Task Update(TicketDTO dto) {
        var existe = await _ticketDAO.GetById(dto.Id);
        if (existe == null)
            throw new Exception("Ticket no encontrado");
        await _ticketDAO.Update(dto);
    }
}