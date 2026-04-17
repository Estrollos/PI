using subsonicApi.Models.DAO.Interfaces;

public class StallModel {
    private readonly IStallDAO _stallDAO;

    public StallModel(IDAOFactory factory) {
        _stallDAO = factory.CreateStallDAO();
    }
    public async Task<List<StallDTO>> GetAll()
    {
       return await _stallDAO.GetAll();
    } 
    public async Task<StallDTO> GetById(int id){
         var evento = await _stallDAO.GetById(id);
         if (evento == null)
            throw new Exception("Evento no encontrado");
        return evento;
    }
    public async Task Create(StallDTO dto) => await _stallDAO.Create(dto);

    public async Task Update(StallDTO dto) {
        var existe = await _stallDAO.GetById(dto.Id);
        if (existe == null)
            throw new Exception("Evento no encontrado");
        await _stallDAO.Update(dto);
    }
}