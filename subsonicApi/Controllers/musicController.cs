using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MusicController : ControllerBase {
    private readonly MusicModel _model;

    public MusicController(IDAOFactory factory) {
        _model = new MusicModel(factory);
    }

    [HttpGet]
    public async Task<ActionResult<List<MusicDTO>>> GetAll() {
        var musics = await _model.GetAll();
        return Ok(musics);
    }
}