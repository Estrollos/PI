using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StallController : ControllerBase {
    private readonly StallModel _model;

    public StallController(IDAOFactory factory) {
        _model = new StallModel(factory);
    }

    [HttpGet]
    public async Task<ActionResult<List<StallDTO>>> GetAll() {
        var stalls = await _model.GetAll();
        return Ok(stalls);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StallDTO>> GetById(int id) {
        var stall = await _model.GetById(id);
        if (stall == null) 
            return NotFound();
        return Ok(stall);
    }
    
    [HttpPost]
    public async Task<ActionResult<StallDTO>> Create(StallDTO dto) {
        if(dto == null)
            return BadRequest();
        await _model.Create(dto);
        return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
    }

    [HttpPut]
    public async Task<IActionResult> Update(StallDTO dto) {
        if(dto == null)
            return BadRequest();
        await _model.Update(dto);
        return Ok(dto); 
    }
}