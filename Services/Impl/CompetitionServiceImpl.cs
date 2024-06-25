using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class CompetitionServiceImpl : ICompetitionService
{
    private readonly ICompetitionsRepository _repository;

    public CompetitionServiceImpl(ICompetitionsRepository repository)
    {
        _repository = repository;
    }

    public CompetitionDTO Get(int id)
    {
        return _repository.Get(id);
    }

    public List<CompetitionDTO> GetAll()
    {
        return _repository.GetAll();
    }

    public CompetitionDTO Create(CompetitionDTO competitionDTO)
    {
        return _repository.Create(competitionDTO);
    }

    public CompetitionDTO Update(CompetitionDTO competitionDTO)
    {
        return _repository.Update(competitionDTO);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}
