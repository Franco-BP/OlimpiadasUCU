using OlimpiadasUCU.Services;
using OlimpiadasUCU.Services.Impl;
using OlimpiadasUCU.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder = BuilderServices.AddServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
