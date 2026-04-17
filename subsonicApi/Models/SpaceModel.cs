using subsonicApi.Models.DAO.Interfaces;
public class SpaceModel
{
    private readonly ISpaceDAO _spaceDAO;

    public SpaceModel(IDAOFactory factory) {
        _spaceDAO = factory.CreateSpaceDAO();
    }

    public async Task<List<SpaceDTO>> GetAll()
    {
       return await _spaceDAO.GetAll();
    } 

    public async Task<SpaceDTO> GetById(int id){
         var news = await _spaceDAO.GetById(id);
         if (news == null)
            throw new Exception("Noticia no encontrada");
        return news;
    }

    public async Task Update(SpaceDTO dto) {
        var existe = await _spaceDAO.GetById(dto.Id);
        if (existe == null)
            throw new Exception("Espacio no encontrado");
        await _spaceDAO.Update(dto);
    }
}