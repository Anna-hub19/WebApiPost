using PocPostgress.DataBase.DataBase;
using PocPostgress.Repository.Repositorios;
using PocPostgress.Repository.Repositorios.Interfaces;
using PocPostgress.Services.Service.Interfaces;
using PocPostgress.Services.Services;
using PocPostgress.Services.Services.Domain;
using PocPostgress.Services.Services.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AlunoService>();

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();
// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddTransient<IAdicionarAlunosRepository, AlunosRepositorio>();
builder.Services.AddTransient<IAlunoService, AlunoService>();
builder.Services.AddTransient<IAlunoDomainService, AlunoDomainService>();
builder.Services.AddSingleton<ConnectionDB>();

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
