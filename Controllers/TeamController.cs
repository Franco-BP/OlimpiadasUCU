using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController : ControllerBase
{
    private readonly ITeamService _service;

    public TeamController(ITeamService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public ActionResult<TeamDTO> Get(int id)
    {
        return _service.Get(id);
    }

    [HttpGet("getAll")]
    public ActionResult<List<TeamDTO>> GetAll()
    {
        return _service.GetAll();
    }

    [HttpPost]
    public ActionResult<TeamDTO> Create([FromBody] TeamDTO teamDTO)
    {
        return _service.Create(teamDTO);
    }

    [HttpPut]
    public ActionResult<TeamDTO> Update([FromBody] TeamDTO teamDTO)
    {
        return _service.Update(teamDTO);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}
