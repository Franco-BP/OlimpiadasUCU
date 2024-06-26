using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Repositories.Impl;

public class ResultRepository : IResultRepository
{
    private readonly IMapper _mapper;
    private readonly DatabaseSingleton _database;

    public ResultRepository(IMapper mapper)
    {
        _mapper = mapper;
        _database = DatabaseSingleton.GetInstance();
    }

    public ResultDTO Get(int id)
    {
        var results = _database.Results.Find(c => c.Id == id);
        return _mapper.Map<ResultDTO>(results);
    }

    public List<ResultDTO> GetAll()
    {
        return _database.Results.Select(c => _mapper.Map<ResultDTO>(c)).ToList();
    }

    public List<ResultDTO> GetAllByParticipantId(int id)
    {
        return _database.Results.Where(c => c.ParticipantId.Id == id).Select(c => _mapper.Map<ResultDTO>(c)).ToList();
    }

    public ResultDTO Create(ResultDTO resultDTO)
    {
        var result = _mapper.Map<Result>(resultDTO);
        _database.Results.Add(result);
        return resultDTO;
    }

    public ResultDTO Update(ResultDTO resultDTO)
    {
        var existingResult = _database.Results.Find(c => c.Id == resultDTO.Id);

        existingResult.ResultValue = resultDTO.ResultValue;
        existingResult.Comment = resultDTO.Comment;
        existingResult.Position = resultDTO.Position;
        return _mapper.Map<ResultDTO>(existingResult);
    }

    public void Delete(int id)
    {
        var result = _database.Results.Find(c => c.Id == id);
        _database.Results.Remove(result);
    }
}
