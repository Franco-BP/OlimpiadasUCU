using OlimpiadasUCU.DTO;


namespace OlimpiadasUCU.Repositories;

public interface IResultRepository : ICRUDRepository<ResultDTO>
{
    ResultDTO Get(int id);
    List<ResultDTO> GetAll();
    List<ResultDTO> GetAllByParticipantId(int id);
    ResultDTO Create(ResultDTO resultDTO);
    ResultDTO Update(ResultDTO resultDTO);
    void Delete(int id);

}
