using OlimpiadasUCU.Utils;

var builder = WebApplication.CreateBuilder(args);

// Create the App director
WebApplicationDirector director = new WebApplicationDirector(builder);

// Make the application.
builder = director.MakeWebApplication();
WebApplication app = builder.Build();

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
