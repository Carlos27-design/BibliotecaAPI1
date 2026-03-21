using BibliotecaAPI;
using BibliotecaAPI.Data;
using BibliotecaAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//área de servicios;
builder.Services.AddTransient<ServicioTransient>();
builder.Services.AddScoped<ServicioScoped>();
builder.Services.AddSingleton<ServicioSingleton>();
//Si queremos compartir estado entre distintas peticiones Http Utilizamos Singleton. Si queremos mantener el estado
//dentro del mismo contexto Http utilizamos Scoped. Si no nos interesa compartir el estado Utilizamos Transient.
builder.Services.AddSingleton<IValoresRepositories, RepositorioValoresOracle>();

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    )
);



var app = builder.Build();

// area de middlewares


//El orden de los middlewares es importante, ya que se ejecutan en el orden en el que se registran.

app.UseLogueaPeticion();



app.UseBloquearPeticion();

app.MapControllers();

app.Run();
