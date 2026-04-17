namespace subsonicApi.Models.DAO.Interfaces
{
    public interface IProductDAO
    {
        Task<List<ProductDTO>> GetAll();
        Task<ProductDTO> GetById(int id);
    }
}