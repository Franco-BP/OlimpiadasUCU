using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.Database;

public class DatabaseSingleton
{
  private static DatabaseSingleton instance { get; set; }

  private DatabaseSingleton()
  {
    this.JudgesRegistered = new List<Judge>();
    this.Competitions = new List<Competition>();
  }

  public static DatabaseSingleton GetInstance()
  {
    return DatabaseSingleton.instance ??= new DatabaseSingleton();
  }

  public readonly List<Judge> JudgesRegistered;

  public readonly List<Competition> Competitions = new List<Competition>();
}