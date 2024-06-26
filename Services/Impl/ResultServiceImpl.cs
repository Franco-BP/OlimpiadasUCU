using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class ResultServiceImpl : IResultService
{
    private readonly IResultRepository _repository;

    public ResultServiceImpl(IResultRepository repository)
    {
        _repository = repository;
    }

    public ResultDTO Get(int id)
    {
        return _repository.Get(id);
    }

    public List<ResultDTO> GetAll()
    {
        return _repository.GetAll();
    }

    public List<ResultDTO> GetAllByParticipantId(int id)
    {
        return _repository.GetAllByParticipantId(id);
    }

    public ResultDTO Create(ResultDTO resultDTO)
    {
        return _repository.Create(resultDTO);
    }

    public ResultDTO Update(ResultDTO resultDTO)
    {
        return _repository.Update(resultDTO);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}
