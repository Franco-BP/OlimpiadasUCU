using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Repositories.Impl;

public class ParticipantRepository : IParticipantRepository
{
    private readonly IMapper _mapper;
    private readonly DatabaseSingleton _database;

    public ParticipantRepository(IMapper mapper)
    {
        _mapper = mapper;
        _database = DatabaseSingleton.GetInstance();
    }

    public ParticipantDTO Get(int id)
    {
        var participant = _database.Participants.Find(c => c.Id == id);
        return _mapper.Map<ParticipantDTO>(participant);
    }

    public List<ParticipantDTO> GetAll()
    {
        return _database.Participants.Select(c => _mapper.Map<ParticipantDTO>(c)).ToList();
    }

    public ParticipantDTO Create(ParticipantDTO participantDTO)
    {
        var participant = _mapper.Map<Participant>(participantDTO);
        _database.Participants.Add(participant);
        return participantDTO;
    }

    public ParticipantDTO Update(ParticipantDTO participantDTO)
    {
        var existingParticipant = _database.Participants.Find(c => c.Id == participantDTO.Id);

        existingParticipant.DocumentNumber = participantDTO.DocumentNumber;
        existingParticipant.Name = participantDTO.Name;
        existingParticipant.Country = participantDTO.Country;
        existingParticipant.BloodType = participantDTO.BloodType;
        existingParticipant.Medals = participantDTO.Medals;
        existingParticipant.Competitions = participantDTO.Competitions;

        return _mapper.Map<ParticipantDTO>(existingParticipant);
    }

    public void Delete(int id)
    {
        var participant = _database.Participants.Find(c => c.Id == id);
        _database.Participants.Remove(participant);
    }
}