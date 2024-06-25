using Microsoft.AspNetCore.Mvc;
using OlimpiadasUCU.Database;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OlimpiadasUCU.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PopulateController() : ControllerBase
{
  private DatabaseSingleton database = DatabaseSingleton.GetInstance();

  // POST > 'api/judge/{nickname}'
  [HttpPost]
  public void PopulateDataBase()
  {
    for (int i = 1; i < 11; i++)
    {
      Judge judge = new()
      {
          Nickname = $"Judge{i}", // Simple nickname generation
          Password = $"password{i}", // Placeholder passwords (not secure!)
          Name = $"Sample Judge {i}", // Sample names
          Email = $"SampleJudge{i}@mail.com", // Sample names
          DocumentNumber = $"{i}" // Sample names
      };
      database.JudgesRegistered.Add(judge);

      Competition competition = new()
      {
          Id = i,
          Round = i + 10,
          Description = $"Competition Description {i}",
          Date = new DateTime(2000 + i, 06, 27),
          JudgeNickname = judge.Nickname
      };
      database.Competitions.Add(competition);

      Participant participant = new()
      {
        Id = i,
        DocumentNumber = 15+i,
        Name = $"Participant-{i}",
        Country = $"Country{i}",
        BloodType = $"BloodType{i}"
      };
      database.Participants.Add(participant);

      Result result = new()
      {
        Id = i,
        ResultValue = 10+i,
        Comment = $"Comment for Result-{i}",
        Position = 5 + i,
        ParticipantId = participant.Id,
      };
      database.Results.Add(result);
    }
  }
}
