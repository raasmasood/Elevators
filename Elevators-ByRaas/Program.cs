using DataAccess;
using Microsoft.AspNetCore.Builder;
using Services;
using Services.Contracts;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IFloorService, FloorService>();
builder.Services.AddScoped<IElevatorService, ElevatorService>();
builder.Services.AddSingleton<ElevatorRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
    $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.MapControllers();

app.Run();
