using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JudgeController(IJudgeService judgeService) : ControllerBase
{
  private IJudgeService JudgeService => judgeService;

  // GET > 'api/judge/{nickname}'
  [HttpGet("{nickname}")]
  public JudgeDTO Get(string nickname)
  {
    return JudgeService.Get(nickname);
  }

  // GET > 'api/judge/getAll'
  [HttpGet("getAll")]
  public List<JudgeDTO> GetAll()
  {
    return JudgeService.GetAll();
  }

  // POST > 'api/judge'
  [HttpPost]
  public JudgeDTO Create([FromBody] JudgeDTO judgeDTO)
  {
    return JudgeService.Create(judgeDTO);
  }

  // PUT > 'api/judge'
  [HttpPut]
  public JudgeDTO Update([FromBody] JudgeDTO judgeDTO)
  {
    /*  NOT IMPLEMENTED  */
    return new JudgeDTO();
  }

  // DELETE > 'api/judge/{nickname}
  [HttpDelete("{nickname}")]
  public void Delete(string nickname)
  {
    /////////
  }

  // POST > 'api/judge/login'
  [HttpPost("login")]
  public JudgeDTO Login([FromBody] JudgeDTO judgeDTO)
  {
    return JudgeService.Login(judgeDTO);
  }
}