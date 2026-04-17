namespace subsonicApi.Models.DAO.Interfaces
{
    public interface IStallDAO
    {
        Task<List<StallDTO>> GetAll();
        Task<StallDTO> GetById(int id);
        Task Create(StallDTO dto);
        Task Update(StallDTO dto);
    }
}