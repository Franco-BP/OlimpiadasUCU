using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface IResultService : ICRUDService<ResultDTO>
{
    ResultDTO Get(int id);
    List<ResultDTO> GetAll();
    List<ResultDTO> GetAllByParticipantId(int id);
    ResultDTO Create(ResultDTO resultDTO);
    ResultDTO Update(ResultDTO resultDTO);
    void Delete(int id);
}
