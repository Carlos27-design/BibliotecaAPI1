using BibliotecaAPI;
using BibliotecaAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//área de servicios;

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
