namespace OlimpiadasUCU.Models;

public class GroupCompetition : Competition
{
    // Número de equipos permitidos en la competición
    public override List<Participant> CalculateWinner()
    {
        return Ranking.Take(1).ToList();
    }

    public int NumberOfTeams { get; set; }
    public List<Team> Teams { get; set; }

    public Result results { get; set; }
    public GroupCompetition()
    {
        Teams = new List<Team>();
    }
}
