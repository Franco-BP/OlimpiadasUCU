using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResultController : ControllerBase
{
    private readonly IResultService _service;

    public ResultController(IResultService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public ResultDTO Get(int id)
    {
        return _service.Get(id);
    }

    [HttpGet("getAll")]
    public List<ResultDTO> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("getAllByParticipantId/{id}")]
    public List<ResultDTO> GetAllByParticipantId(int id)
    {
        return _service.GetAllByParticipantId(id);
    }

    [HttpPost]
    public ResultDTO Create([FromBody] ResultDTO resultDTO)
    {
        return _service.Create(resultDTO);
    }

    [HttpPut]
    public ResultDTO Update([FromBody] ResultDTO resultDTO)
    {
        return _service.Update(resultDTO);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _service.Delete(id);
    }
}
