namespace subsonicApi.Models.DAO.Interfaces
{
    public interface INewDAO
    {
        Task<List<NewsDTO>> GetAll();
        Task<NewsDTO> GetById(int id);
    }
}