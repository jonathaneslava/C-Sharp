//Permite utilizar las clases de EF Core
using Microsoft.EntityFrameworkCore;

using SistemaEscolar.Models;

namespace SistemaEscolar.Data
{
    public class SistemaEscolarContext : DbContext //Indica que nuestra clase hereda de DbContext, que administra la interacción con la base de datos.
    {
        public SistemaEscolarContext(
            DbContextOptions<SistemaEscolarContext> options) //Recibe la configuración que utilizaremos para conectarnos a SQL Server.
            : base(options)
        {
        }
        //Representa el conjunto de alumnos que EF Core manejará en la base de datos, mediante una tabla llamada Alumnos.
        public DbSet<Alumnos> Alumnos { get; set; }
    }
}