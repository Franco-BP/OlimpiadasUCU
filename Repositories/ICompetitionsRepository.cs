using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface ICompetitionsRepository : ICRUDRepository<CompetitionDTO>
{
    List<CompetitionDTO> GetAll();
    CompetitionDTO Get(int id);
    CompetitionDTO Update(CompetitionDTO competitionDTO);
    CompetitionDTO Create(CompetitionDTO competitionDTO);
    void Delete(int id);
}
