using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.Repositories.Impl;
using OlimpiadasUCU.Services;
using OlimpiadasUCU.Services.Impl;

namespace OlimpiadasUCU.Utils;

public class WebApplicationDirector
{
  private WebApplicationBuilder Builder { get; set; }
  public WebApplicationDirector(WebApplicationBuilder builder)
  {
    this.Builder = builder;
  }
  public void ChangeBuilder(WebApplicationBuilder builder)
  {
    this.Builder = builder;
  }
  public WebApplicationBuilder MakeWebApplication()
  {
    Builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    Builder.Services.AddEndpointsApiExplorer();
    Builder.Services.AddSwaggerGen();

    // Add Mapping configuration
    Builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
    Builder.Services.AddScoped<IJudgeService, JudgeServiceImpl>();
    Builder.Services.AddScoped<IJudgesRepository, JudgesRepository>();

    Builder.Services.AddScoped<ICompetitionService, CompetitionServiceImpl>();
    Builder.Services.AddScoped<ICompetitionsRepository, CompetitionsRepository>();

    Builder.Services.AddScoped<ITeamService, TeamServiceImpl>();
    Builder.Services.AddScoped<ITeamRepository, TeamRepository>();

    Builder.Services.AddScoped<IParticipantService, ParticipantServiceImpl>();
    Builder.Services.AddScoped<IParticipantRepository, ParticipantRepository>();

    Builder.Services.AddScoped<IResultService, ResultServiceImpl>();
    Builder.Services.AddScoped<IResultRepository, ResultRepository>();
    return Builder;
  }
}