using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class NewController : ControllerBase
{
     private readonly NewModel _model;

    public NewController(IDAOFactory factory) {
        _model = new NewModel(factory);
    }

    [HttpGet]
    public async Task<ActionResult<List<EventDTO>>> GetAll() {
        var eventos = await _model.GetAll();
        return Ok(eventos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EventDTO>> GetById(int id) {
        var evento = await _model.GetById(id);
        if (evento == null) 
            return NotFound();
        return Ok(evento);
    }
}