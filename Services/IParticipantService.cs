using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface IParticipantService : ICRUDService<ParticipantDTO>
{
    ParticipantDTO Get(int id);
    List<ParticipantDTO> GetAll();
    ParticipantDTO Create(ParticipantDTO participantDTO);
    ParticipantDTO Update(ParticipantDTO participantDTO);
    void Delete(int id);
}
