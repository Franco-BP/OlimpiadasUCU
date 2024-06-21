using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Repositories.Impl;

public class JudgesRepository : IJudgesRepository
{
  private readonly IMapper Mapper;
  private readonly DatabaseSingleton dataBase;
  public JudgesRepository(IMapper mapper)
  {
    this.Mapper = mapper;
    this.dataBase = DatabaseSingleton.GetInstance();
  }

  public JudgeDTO Get(string nickname)
  {
    Console.WriteLine("Getting: " + nickname);
    Judge? judge = dataBase.JudgesRegistered.Find(judge => judge.Nickname == nickname);
    Console.WriteLine("List: " + dataBase.JudgesRegistered.Count + "\nGet: " + judge);
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
    dataBase.JudgesRegistered.Add(newJudge);
    Console.WriteLine("List: " + dataBase.JudgesRegistered.Count);
    return judgeDTO;
  }

  public List<JudgeDTO> GetAll()
  {
    List<JudgeDTO> judgeDTOList = new List<JudgeDTO>();
    foreach(Judge element in dataBase.JudgesRegistered)
    {
      judgeDTOList.Add(Mapper.Map<JudgeDTO>(element));
    }
    Console.WriteLine("List: " + dataBase.JudgesRegistered.Count);
    return judgeDTOList;
  }

  public JudgeDTO Login(JudgeDTO judgeDTO)
  {
    Judge? judge = dataBase.JudgesRegistered.Find(element => (element.Nickname == judgeDTO.Nickname) && (element.Password == judgeDTO.Password));
    if (judge != null)
    {
      return Mapper.Map<JudgeDTO>(judge);
    } else {
      return new JudgeDTO();
    }
  }
}