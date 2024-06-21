using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface IJudgeService {
  JudgeDTO Get(string nickname);
  JudgeDTO Create(JudgeDTO judgeDTO);
  List<JudgeDTO> GetAll();
  JudgeDTO Login(JudgeDTO judgeDTO);
}