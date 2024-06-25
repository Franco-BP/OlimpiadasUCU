using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface ITeamService : ICRUDService<TeamDTO>
{
    TeamDTO Get(int id);
    List<TeamDTO> GetAll();
    TeamDTO Create(TeamDTO teamDTO);
    TeamDTO Update(TeamDTO teamDTO);
    void Delete(int id);
}
