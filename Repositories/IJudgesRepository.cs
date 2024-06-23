using OlimpiadasUCU.Models;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Repositories;

public interface IJudgesRepository : ICRUDRepository<JudgeDTO>
{
  JudgeDTO Get(string nickname);
  JudgeDTO Login(JudgeDTO judgeDTO);
}