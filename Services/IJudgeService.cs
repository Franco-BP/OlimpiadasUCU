using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface IJudgeService : ICRUDService<JudgeDTO>
{
  JudgeDTO GetByName(string nickname);
  JudgeDTO Login(JudgeDTO judgeDTO);

  List<JudgeDTO> GetAll();

  JudgeDTO Update(JudgeDTO judgeDTO);

  void DeleteByNickname(string nickname);
}