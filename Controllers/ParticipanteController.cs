using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using OlimpiadasUCU.Controllers; // Asegúrate de usar el namespace correcto para tus modelos

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("[controller]")]
public class ParticipantesController : ControllerBase
{
    private readonly ILogger<ParticipantesController> _logger;

    private static readonly List<Participante> participantes = new List<Participante>
    {
        new Participante { Id = 1, Nombre = "Juan", Apellido = "Perez", Nacionalidad = "Uruguay", Deporte = "Fútbol", Genero = "Masculino" },
        new Participante { Id = 2, Nombre = "Maria", Apellido = "Gonzalez", Nacionalidad = "Argentina", Deporte = "Hockey", Genero = "Femenino" }
    };

    public ParticipantesController(ILogger<ParticipantesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Participante>> GetAll()
    {
        _logger.LogInformation("Obteniendo todos los participantes");
        return Ok(participantes);
    }

    [HttpGet("{id}")]
    public ActionResult<Participante> Get(int id)
    {
        _logger.LogInformation($"Obteniendo participante con ID: {id}");
        var participante = participantes.First(p => p.Id == id);
        if (participante == null)
        {
            return NotFound();
        }
        return Ok(participante);
    }

    [HttpPost]
    public ActionResult<Participante> Create(Participante participante)
    {
        _logger.LogInformation($"Creando un nuevo participante");
        //_participanteService.Add(participante);
        return CreatedAtAction(nameof(Get), new { id = participante.Id }, participante);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Participante participante)
    {
        _logger.LogInformation($"Actualizando participante con ID: {id}");
        if (id != participante.Id)
        {
            return BadRequest("ID del participante no coincide");
        }

        //var existingParticipante = _participanteService.GetById(id);
        //if (existingParticipante == null)
        {
            return NotFound();
        }

        //_participanteService.Update(participante);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _logger.LogInformation($"Eliminando participante con ID: {id}");
        //var participante = _participanteService.GetById(id);
        /* if (participante == null)
        {
            return NotFound();
        } */

        //_participanteService.Delete(id);
        return NoContent();
    }
}
