using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase {
    private readonly TicketModel _model;

    public TicketController(IDAOFactory factory) {
        _model = new TicketModel(factory);
    }

    [HttpGet]
    public async Task<ActionResult<List<TicketDTO>>> GetAll() {
        var tickets = await _model.GetAll();
        return Ok(tickets);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TicketDTO>> GetById(int id) {
        var ticket = await _model.GetById(id);
        if (ticket == null) 
            return NotFound();
        return Ok(ticket);
    }

    [HttpPut]
    public async Task<IActionResult> Update(TicketDTO dto) {
        if(dto == null)
            return BadRequest();
        await _model.Update(dto);
        return Ok(dto); 
    }
}