namespace subsonicApi.Models.DAO.Interfaces
{
    public interface ISpaceDAO
    {
        Task<List<SpaceDTO>> GetAll();
        Task<SpaceDTO> GetById(int id);
        Task Update(SpaceDTO dto);
    }
}