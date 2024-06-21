using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;

namespace OlimpiadasUCU.Utils;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Judge, JudgeDTO>()
          .ForMember(dest => dest.Password, opt => opt.Ignore())
          .ReverseMap();
    }
}