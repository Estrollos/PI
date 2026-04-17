namespace subsonicApi.Models.DAO.Interfaces
{
    public interface IMusicDAO
    {
        Task<List<MusicDTO>> GetAll();
        Task<MusicDTO> GetById(int id);
    }
}