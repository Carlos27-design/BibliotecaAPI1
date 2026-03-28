using BibliotecaAPI;
using BibliotecaAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var diccionarioConfiguracion = new Dictionary<string, string>
{
    { "quien_soy", "un diccionario en memoria" }
};

builder.Configuration.AddInMemoryCollection(diccionarioConfiguracion!);
//área de servicios;

builder.Services.AddOptions<PersonaOpciones>().Bind(builder.Configuration.GetSection(PersonaOpciones.Seccion)).ValidateDataAnnotations().ValidateOnStart();

builder.Services.AddOptions<TarifaOpciones>().Bind(builder.Configuration.GetSection(TarifaOpciones.Seccion)).ValidateDataAnnotations().ValidateOnStart();

builder.Services.AddSingleton<PagosProcesamiento>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    )
);



var app = builder.Build();

// area de middlewares


//El orden de los middlewares es importante, ya que se ejecutan en el orden en el que se registran.



app.MapControllers();

app.Run();
