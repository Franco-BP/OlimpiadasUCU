using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class TeamServiceImpl : ITeamService
{
    private readonly ITeamRepository _repository;

    public TeamServiceImpl(ITeamRepository repository)
    {
        _repository = repository;
    }

    public TeamDTO Get(int id)
    {
        return _repository.Get(id);
    }

    public List<TeamDTO> GetAll()
    {
        return _repository.GetAll();
    }

    public TeamDTO Create(TeamDTO teamDTO)
    {
        return _repository.Create(teamDTO);
    }

    public TeamDTO Update(TeamDTO teamDTO)
    {
        return _repository.Update(teamDTO);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}
