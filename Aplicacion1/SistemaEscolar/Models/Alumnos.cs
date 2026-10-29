// Permite utilizar las anotaciones de validación, como Required y Range.
using System.ComponentModel.DataAnnotations;

//Identifica el espacio de nombres donde estará nuestra clase
namespace SistemaEscolar.Models
{
    public class Alumnos
    {
        public int Id { get; set; }

        // El nombre es obligatorio y debe tener entre 2 y 100 caracteres.
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
        //Se declara la propiedad, obtiene el valor, establece o modifica el valor y hace que Nombre comience con una cadena vacía en lugar de null.
        public string Nombre { get; set; } = string.Empty;

        // La edad debe estar entre 15 y 100 años.
        [Range(15, 100,
            ErrorMessage = "La edad debe estar entre 15 y 100 años.")]
        public int Edad { get; set; }

        // La carrera es obligatoria y debe tener entre 2 y 100 caracteres.
        [Required(ErrorMessage = "La carrera es obligatoria.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "La carrera debe tener entre 2 y 100 caracteres.")]
        public string Carrera { get; set; } = string.Empty;

        // Correo electrónico obligatorio del alumno.
        //Exige que se proporcione un valor. En combinación con la validación de ASP.NET Core, una cadena vacía no será aceptada.
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        //Comprueba que el valor tenga un formato de correo electrónico válido.
        [EmailAddress(ErrorMessage = "Ingresa un correo electrónico válido.")]
        public string Correo { get; set; } = string.Empty;

    }
}