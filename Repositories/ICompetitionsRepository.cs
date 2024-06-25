using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface ICompetitionsRepository : ICRUDRepository<CompetitionDTO>
{
    CompetitionDTO Get(int id);
}
