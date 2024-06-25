using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface ITeamRepository : ICRUDRepository<TeamDTO>
{
    TeamDTO Get(int id);
}
