using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class EventController : ControllerBase {
    private readonly EventModel _model;

    public EventController(IDAOFactory factory) {
        _model = new EventModel(factory);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<List<EventDTO>>> GetAll() {
        var eventos = await _model.GetAll();
        return Ok(eventos);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<EventDTO>> GetById(int id) {
        var evento = await _model.GetById(id);
        if (evento == null) 
            return NotFound();
        return Ok(evento);
    }

    [HttpPut]
    public async Task<IActionResult> Update(EventDTO dto) {
        if(dto == null)
            return BadRequest();
        await _model.Update(dto);
        return Ok(dto); 
    }
}