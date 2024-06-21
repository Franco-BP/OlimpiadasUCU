using OlimpiadasUCU.Models;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Repositories;

public interface IJudgesRepository
{
  JudgeDTO Get(string nickname);
  JudgeDTO Create(JudgeDTO judgeDTO);
  List<JudgeDTO> GetAll();
  JudgeDTO Login(JudgeDTO judgeDTO);
}