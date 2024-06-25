using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface IParticipantRepository : ICRUDRepository<ParticipantDTO>
{
    ParticipantDTO Get(int id);
}
