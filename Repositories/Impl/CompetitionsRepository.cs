using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Repositories.Impl;

public class CompetitionsRepository : ICompetitionsRepository
{
    private readonly IMapper _mapper;
    private readonly DatabaseSingleton _database;

    public CompetitionsRepository(IMapper mapper)
    {
        _mapper = mapper;
        _database = DatabaseSingleton.GetInstance();
    }

    public CompetitionDTO Get(int id)
    {
        var competition = _database.Competitions.Find(c => c.Id == id);
        return _mapper.Map<CompetitionDTO>(competition);
    }

    public List<CompetitionDTO> GetAll()
    {
        return _database.Competitions.Select(c => _mapper.Map<CompetitionDTO>(c)).ToList();
    }

    public CompetitionDTO Create(CompetitionDTO competitionDTO)
    {
        var competition = _mapper.Map<Competition>(competitionDTO);
        _database.Competitions.Add(competition);
        return competitionDTO;
    }

    public CompetitionDTO Update(CompetitionDTO competitionDTO)
    {
        var existingCompetition = _database.Competitions.Find(c => c.Id == competitionDTO.Id);

        existingCompetition.Round = competitionDTO.Round;
        existingCompetition.Description = competitionDTO.Description;
        existingCompetition.Date = competitionDTO.Date;

        return _mapper.Map<CompetitionDTO>(existingCompetition);
    }

    public void Delete(int id)
    {
        var competition = _database.Competitions.Find(c => c.Id == id);
        _database.Competitions.Remove(competition);
    }
}
