using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Repositories.Impl;

public class TeamRepository : ITeamRepository
{
    private readonly IMapper _mapper;
    private readonly DatabaseSingleton _database;

    public TeamRepository(IMapper mapper)
    {
        _mapper = mapper;
        _database = DatabaseSingleton.GetInstance();
    }

    public TeamDTO Get(int id)
    {
        var team = _database.Teams.Find(c => c.Id == id);
        return _mapper.Map<TeamDTO>(team);
    }

    public List<TeamDTO> GetAll()
    {
        return _database.Teams.Select(c => _mapper.Map<TeamDTO>(c)).ToList();
    }

    public TeamDTO Create(TeamDTO teamDTO)
    {
        var team = _mapper.Map<Team>(teamDTO);
        _database.Teams.Add(team);
        return teamDTO;
    }

    public TeamDTO Update(TeamDTO teamDTO)
    {
        var existingTeam = _database.Teams.Find(c => c.Id == teamDTO.Id);

        existingTeam.Number = teamDTO.Number;
        existingTeam.Country = teamDTO.Country;
        existingTeam.ParticipantsAmount = teamDTO.ParticipantsAmount;
        //existingTeam.Participants = teamDTO.Participants;



        return _mapper.Map<TeamDTO>(existingTeam);
    }

    public void Delete(int id)
    {
        var competition = _database.Competitions.Find(c => c.Id == id);
        _database.Competitions.Remove(competition);
    }
}
