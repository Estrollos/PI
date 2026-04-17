using subsonicApi.Models.DAO.Interfaces;

public class NewModel
{
    private readonly INewDAO _newDAO;

    public NewModel(IDAOFactory factory) {
        _newDAO = factory.CreateNewDAO();
    }

    public async Task<List<NewsDTO>> GetAll()
    {
       return await _newDAO.GetAll();
    } 
    public async Task<NewsDTO> GetById(int id){
         var news = await _newDAO.GetById(id);
         if (news == null)
            throw new Exception("Noticia no encontrada");
        return news;
    }
}
