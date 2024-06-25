using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface ICompetitionService : ICRUDService<CompetitionDTO>
{
    CompetitionDTO Get(int id);
    List<CompetitionDTO> GetAll();
    CompetitionDTO Create(CompetitionDTO competitionDTO);
    CompetitionDTO Update(CompetitionDTO competitionDTO);
    void Delete(int id);
}
