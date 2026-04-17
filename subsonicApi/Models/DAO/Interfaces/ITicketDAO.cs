namespace subsonicApi.Models.DAO.Interfaces
{
    public interface ITicketDAO
    {
        Task<List<TicketDTO>> GetAll();
        Task<TicketDTO> GetById(int id);
        Task Update(TicketDTO dto);
    }
}