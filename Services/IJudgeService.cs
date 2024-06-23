using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services;

public interface IJudgeService: ICRUDService<JudgeDTO> {
  JudgeDTO Get(string nickname);
  JudgeDTO Login(JudgeDTO judgeDTO);
}