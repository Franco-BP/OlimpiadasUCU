using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface IParticipantRepository : ICRUDRepository<ParticipantDTO>
{
    List<ParticipantDTO> GetAll();
    ParticipantDTO Get(int id);
    ParticipantDTO Update(ParticipantDTO participantDTO);
    ParticipantDTO Create(ParticipantDTO participantDTO);
    void Delete(int id);
}
