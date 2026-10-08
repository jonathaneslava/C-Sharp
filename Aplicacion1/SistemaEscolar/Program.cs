var builder = WebApplication.CreateBuilder(args); //Preparar mi aplicacion y servicios que va usar

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
