using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompetitionController : ControllerBase
{
    private readonly ICompetitionService _service;

    public CompetitionController(ICompetitionService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public CompetitionDTO Get(int id)
    {
        return _service.Get(id);
    }

    [HttpGet("getAll")]
    public List<CompetitionDTO> GetAll()
    {
        return _service.GetAll();
    }

    [HttpPost]
    public CompetitionDTO Create([FromBody] CompetitionDTO competitionDTO)
    {
        return _service.Create(competitionDTO);
    }

    [HttpPut]
    public CompetitionDTO Update([FromBody] CompetitionDTO competitionDTO)
    {
        return _service.Update(competitionDTO);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _service.Delete(id);
    }
}
