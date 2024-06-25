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

    public ResultDTO Create(ResultDTO resultDTO)
    {
        throw new NotImplementedException("Crear by ResultDTO is not supported for Result.");
    }

    public ResultDTO Create(ResultDTO resultDTO)
    {
        var newResult = new Result
        {
            Id = _database.Results.Any() ? _database.Results.Max(r => r.Id) + 1 : 1,
            ResultValue = resultDTO.ResultValue,
            Comment = resultDTO.Comment,
            Position = resultDTO.Position

        };

        _database.Results.Add(newResult);
        return _mapper.Map<ResultDTO>(newResult);
    }

    public ResultDTO Update(ResultDTO resultDTO)
    {
        var existingResult = _database.Results.Find(c => c.Id == resultDTO.Id);

        existingResult.ResultValue = resultDTO.ResultValue;
        existingResult.Comment = resultDTO.Comment;
        existingResult.Position = resultDTO.Position;
        existingResult.ParticipantId = resultDTO.ParticipantId;
        existingResult.CompetitionId = resultDTO.CompetitionId;

        return _mapper.Map<ResultDTO>(existingResult);
    }

    public void Delete(int id)
    {
        var result = _database.Results.Find(c => c.Id == id);
        _database.Results.Remove(result);
    }
}
