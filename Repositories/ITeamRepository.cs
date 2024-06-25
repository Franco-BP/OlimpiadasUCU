using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface ITeamRepository : ICRUDRepository<TeamDTO>
{
    List<TeamDTO> GetAll();
    TeamDTO Get(int id);
    TeamDTO Update(TeamDTO teamDTO);
    TeamDTO Create(TeamDTO teamDTO);
    void Delete(int id);
}
