using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.DTO;

namespace OlimpiadasUCU.Services.Impl;

public class JudgeServiceImpl(IJudgesRepository judgesRepository) : IJudgeService
{
  private IJudgesRepository JudgesRepository => judgesRepository;

  public JudgeDTO GetByName(string nickname)
  {
    return JudgesRepository.Get(nickname);
  }

  public JudgeDTO Get(int id)
  {
    throw new NotImplementedException("Get by id is not supported for Judge.");
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
  public JudgeDTO Update(JudgeDTO dto)
  {
    return JudgesRepository.Update(dto);
  }

  public void Delete(int id)
  {
    throw new NotImplementedException("Delete by id is not supported for Judge.");
  }

  public void DeleteByNickname(string nickname)
  {
    JudgesRepository.DeleteByNickname(nickname);
  }

}