using OlimpiadasUCU.Repositories;
using OlimpiadasUCU.Repositories.Impl;
using OlimpiadasUCU.Services;
using OlimpiadasUCU.Services.Impl;

namespace OlimpiadasUCU.Utils;

public static class BuilderServices
{
  public static WebApplicationBuilder AddServices(WebApplicationBuilder builder)
  {
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Add Mapping configuration
    builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
    builder.Services.AddScoped<IJudgeService, JudgeServiceImpl>();
    builder.Services.AddScoped<IJudgesRepository, JudgesRepository>();

    return builder;
  }
}