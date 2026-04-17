namespace subsonicApi.Models.DAO.Interfaces
{
    public interface IClientDAO
    {
        Task<List<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int id);
        Task<ClientDTO> GetByEmail(string email);
        Task Create(ClientDTO dto);
        Task Update(ClientDTO dto);
    }
}