using ConcessionariaAPI.Contexts;
using ConcessionariaAPI.Interfaces;
using ConcessionariaAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ConcessionariaContext>(options =>
    // Diz que o banco é SQL Server e busca a connection string chamada "Escola"
    // dentro da seção ConnectionStrings do appsettings.json.
    options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));

builder.Services.AddScoped<IVeiculos, VeiculoRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/veiculos", (ConcessionariaContext db) => db.Veiculo.ToList());

app.Run();
