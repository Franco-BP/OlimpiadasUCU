using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.Database;

public class DatabaseSingleton
{
  private static DatabaseSingleton instance { get; set; }

  private DatabaseSingleton()
  {
    this.JudgesRegistered = new List<Judge>();
    this.Competitions = new List<Competition>();
    this.Teams = new List<Team>();
    this.Participants = new List<Participant>();
  }

  public static DatabaseSingleton GetInstance()
  {
    return DatabaseSingleton.instance ??= new DatabaseSingleton();
  }

  public readonly List<Judge> JudgesRegistered;

  public readonly List<Competition> Competitions = new List<Competition>();

  public readonly List<Team> Teams;

  public readonly List<Participant> Participants = new List<Participant>();
}