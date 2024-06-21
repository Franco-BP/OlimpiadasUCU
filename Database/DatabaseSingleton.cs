using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.Database;

public class DatabaseSingleton
{
  private static DatabaseSingleton instance {get; set; }

  private DatabaseSingleton()
  {
    this.JudgesRegistered = new List<Judge>();
  }

  public static DatabaseSingleton GetInstance() {
    return DatabaseSingleton.instance ??= new DatabaseSingleton();
  }

  public readonly List<Judge> JudgesRegistered;
}