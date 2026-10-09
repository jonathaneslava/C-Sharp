//Identifica el espacio de nombres donde estará nuestra clase
namespace SistemaEscolar.Models
{
    public class Alumnos
    {
        public int Id { get; set; }

        //Se declara la propiedad, obtiene el valor, establece o modifica el valor y hace que Nombre comience con una cadena vacía en lugar de null.
        public string Nombre { get; set; } = string.Empty;

        public int Edad { get; set; }

        public string Carrera { get; set; } = string.Empty;
    }
}