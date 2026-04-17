using subsonicApi.Models.DAO.Interfaces;

public class MusicModel {
    private readonly IMusicDAO _musicDAO;

    public MusicModel(IDAOFactory factory) {
        _musicDAO = factory.CreateMusicDAO();
    }
    public async Task<List<MusicDTO>> GetAll()
    {
       return await _musicDAO.GetAll();
    } 
    public async Task<MusicDTO> GetById(int id){
         var music = await _musicDAO.GetById(id);
         if (music == null)
            throw new Exception("Lista no encontrada");
        return music;
    }
}