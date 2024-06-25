namespace OlimpiadasUCU.Models;

public class SingleCompetition : Competition
{
    public override List<Participant> CalculateWinner()
    {
        return Ranking.Take(1).ToList();
    }
    // Asumiendo que las competiciones individuales pueden tener un requisito especial como un tipo de equipamiento.
    public Result result { get; set; }
}
