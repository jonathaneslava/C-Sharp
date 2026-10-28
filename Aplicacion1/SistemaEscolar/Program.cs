using SistemaEscolar.Services;
using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;

var builder = WebApplication.CreateBuilder(args); //Preparar mi aplicacion y servicios que va usar

// Registrar el servicio de alumnos 
//builder.Services: es el contenedor donde registramos los servicios que la aplicación puede utilizar.
//AddSingleton: indica que se utilizará una misma instancia del servicio durante la vida de la aplicación
//<AlumnoService>: especifica qué clase queremos registrar.
//Una instancia por solicitud HTTP, lo que encaja con el uso habitual de DbContext.
builder.Services.AddScoped<AlumnoService>();

//Registra nuestro contexto en el sistema de inyección de dependencias.
builder.Services.AddDbContext<SistemaEscolarContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConexionSQL"))); //Recupera la conexión que guardamos en appsettings.json

// Add services to the container.
builder.Services.AddControllers(); //Esta aplicacion va usar controllers
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //Swagger Permite probar la API desde una interfaz web 

var app = builder.Build(); //Termina de preparar la configuracion y obtenemos nuestra aplicacion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); //Configura la redireccion de HTTP a HTTPS

app.UseAuthorization(); //Esto prepara el middleware de autorización.

app.MapControllers(); //Conecta nuestros controllers con la aplicacion

app.Run(); //la plicacion empieza a ejecutarse
