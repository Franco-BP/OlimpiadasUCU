using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParticipantController : ControllerBase
{
    private readonly IParticipantService _service;

    public ParticipantController(IParticipantService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public ParticipantDTO Get(int id)
    {
        return _service.Get(id);
    }

    [HttpGet("getAll")]
    public List<ParticipantDTO> GetAll()
    {
        return _service.GetAll();
    }

    [HttpPost]
    public ParticipantDTO Create([FromBody] ParticipantDTO participantDTO)
    {
        return _service.Create(participantDTO);
    }

    [HttpPut]
    public ParticipantDTO Update([FromBody] ParticipantDTO participantDTO)
    {
        return _service.Update(participantDTO);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _service.Delete(id);
    }
}
