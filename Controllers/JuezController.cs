using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JuezController : ControllerBase
{
  // GET > 'api/juez/{id}'
  [HttpGet("{id}")]
  public JuezDTO Get(int id)
  {
    return new JuezDTO();
  }

  // POST > 'api/juez/login/{nickname}'
  [HttpPost("login/{nickname}")]
  public JuezDTO Login(string nickname, [FromBody] string contrasenia)
  {
    return new JuezDTO();
  }

  // POST > 'api/juez'
  [HttpPost]
  public JuezDTO Create(JuezDTO juez)
  {
    return new JuezDTO();
  }

  // PUT > 'api/juez'
  [HttpPut]
  public JuezDTO Update([FromBody] JuezDTO juez)
  {
    return new JuezDTO();
  }

  // DELETE > 'api/juez/{id}
  [HttpDelete("{id}")]
  public void Delete(int id)
  {
    /////////
  }
}