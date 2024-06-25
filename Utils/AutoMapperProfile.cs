using AutoMapper;
using OlimpiadasUCU.DTO;
using OlimpiadasUCU.Models;
using OlimpiadasUCU.Database;

namespace OlimpiadasUCU.Utils;
public class AutoMapperProfile : Profile
{
  public AutoMapperProfile()
  {
    CreateMap<Judge, JudgeDTO>()
      .ForMember(dest => dest.Password, opt => opt.Ignore())
      .ReverseMap();

    CreateMap<Competition, CompetitionDTO>()
       .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
       .ForMember(dest => dest.Round, opt => opt.MapFrom(src => src.Round))
       .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
       .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
        .ReverseMap();
  }
}