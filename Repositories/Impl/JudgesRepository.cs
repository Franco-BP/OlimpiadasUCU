using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.Repositories.Impl;

public class JudgesRepository(IMapper mapper) : IJudgesRepository
{
  private List<Judge> JudgesRegistered => new List<Judge>();
  private IMapper Mapper => mapper;

  public JudgeDTO Get(string nickname)
  {
    Console.WriteLine("Getting: " + nickname);
    Judge? judge = JudgesRegistered.Find(judge => judge.Nickname.ToLower() == nickname.ToLower());
    Console.WriteLine("List: " + JudgesRegistered[0] + "\nGet: " + judge);
    if (judge != null)
    {
      return Mapper.Map<JudgeDTO>(judge);
    } else {
      return new JudgeDTO();
    }
  }

  public JudgeDTO Create(JudgeDTO judgeDTO)
  {
    Judge newJudge = Mapper.Map<Judge>(judgeDTO);
    // Password is ignored in Mapper to avoid security issues.
    newJudge.Password = judgeDTO.Password;
    JudgesRegistered.Add(newJudge);
    return judgeDTO;
  }

  public List<JudgeDTO> GetAll()
  {
    List<JudgeDTO> judgeDTOList = new List<JudgeDTO>();
    foreach(Judge element in JudgesRegistered)
    {
      judgeDTOList.Add(Mapper.Map<JudgeDTO>(element));
    }
    return judgeDTOList;
  }

  public JudgeDTO Login(JudgeDTO judgeDTO)
  {
    Judge? judge = JudgesRegistered.Find(element => (element.Nickname == judgeDTO.Nickname) && (element.Password == judgeDTO.Password));
    if (judge != null)
    {
      return Mapper.Map<JudgeDTO>(judge);
    } else {
      return new JudgeDTO();
    }
  }
}