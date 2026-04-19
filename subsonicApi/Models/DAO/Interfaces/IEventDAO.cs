namespace subsonicApi.Models.DAO.Interfaces
{
    public interface IEventDAO 
    {
        Task<List<EventDTO>> GetAll();
        Task<EventDTO> GetById(int id);
        Task Update(EventDTO dto);
    }
}