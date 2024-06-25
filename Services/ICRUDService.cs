using OlimpiadasUCU.DTO;
namespace OlimpiadasUCU.Services;

public interface ICRUDService<DTO>
{
  DTO Get(int id);
  DTO Create(DTO dto);
  List<DTO> GetAll();
  DTO Update(DTO dto);
  void Delete(int id);

  public interface IJudgeService : ICRUDService<JudgeDTO>
  {
    void DeleteByNickname(string nickname);
    DTO GetByName(string nickname);
  }
}