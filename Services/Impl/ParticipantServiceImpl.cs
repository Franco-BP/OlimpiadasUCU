using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class ParticipantServiceImpl : IParticipantService
{
    private readonly IParticipantRepository _repository;

    public ParticipantServiceImpl(IParticipantRepository repository)
    {
        _repository = repository;
    }

    public ParticipantDTO Get(int id)
    {
        return _repository.Get(id);
    }

    public List<ParticipantDTO> GetAll()
    {
        return _repository.GetAll();
    }

    public ParticipantDTO Create(ParticipantDTO participantDTO)
    {
        return _repository.Create(participantDTO);
    }

    public ParticipantDTO Update(ParticipantDTO participantDTO)
    {
        return _repository.Update(participantDTO);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}
