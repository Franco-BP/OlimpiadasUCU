using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class JudgeServiceImpl(IJudgesRepository judgesRepository) : IJudgeService
{
  private IJudgesRepository JudgesRepository => judgesRepository;

  public JudgeDTO Get(string nickname)
  {
    return JudgesRepository.Get(nickname);
  }

  public JudgeDTO Create(JudgeDTO judgeDTO)
  {
    return JudgesRepository.Create(judgeDTO);
  }

  public List<JudgeDTO> GetAll()
  {
    return JudgesRepository.GetAll();
  }

  public JudgeDTO Login(JudgeDTO judgeDTO)
  {
    return JudgesRepository.Login(judgeDTO);
  }

  // NOT IMPLEMENTED
  public JudgeDTO Update(JudgeDTO dto)
  {
      throw new NotImplementedException();
  }

  // NOT IMPLEMENTED
  public void Delete(JudgeDTO dto)
  {
      throw new NotImplementedException();
  }
}