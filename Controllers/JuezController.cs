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

  // POST > 'api/juez/login/{id}'
  [HttpPost("login")]
  public JuezDTO Login([FromBody] string nickname, [FromBody] string contrasenia)
  {
    return new JuezDTO();
  }

  // POST > 'api/juez'
  [HttpPost]
  public JuezDTO Create([FromBody] JuezDTO juez, [FromBody] string contrasenia)
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