using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Services;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JudgeController(IJudgeService judgeService) : ControllerBase
{
  private IJudgeService JudgeService => judgeService;

  // GET > 'api/judge/{nickname}'
  [HttpGet("{nickname}")]
  public JudgeDTO GetByName(string nickname)
  {
    return JudgeService.GetByName(nickname);
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
    return JudgeService.Update(judgeDTO);
  }

  // DELETE > 'api/judge/{id}
  [HttpDelete("{nickname}")]
  public void DeleteByNickname(string nickname)
  {
    JudgeService.DeleteByNickname(nickname);
  }

  // POST > 'api/judge/login'
  [HttpPost("login")]
  public JudgeDTO Login([FromBody] JudgeDTO judgeDTO)
  {
    return JudgeService.Login(judgeDTO);

  }
}