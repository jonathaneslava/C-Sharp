using SistemaEscolar.Models;

namespace SistemaEscolar.Services
{
    //Se crea la clase AlumnoService
    public class AlumnoService
    {
        //Por ahora utilizamos la misma lista temporal de alumnos.
        private static readonly List<Alumnos> alumnos = new List<Alumnos>
        {
            new Alumnos
            {
                Id = 1,
                Nombre = "Carlos",
                Edad = 20,
                Carrera = "Administración"
            },
            new Alumnos
            {
                Id = 2,
                Nombre = "Pedro",
                Edad = 25,
                Carrera = "Medicina"
            }
        };

        // Busca un alumno utilizando su identificador.
        public Alumnos? ObtenerAlumnoPorId(int id)
        {
            //Find recorre la lista hasta encontrar un alumno cuyo Id coincida con el valor recibido.
            Alumnos? alumno = alumnos.Find(a => a.Id == id);
            //Devuelve el objeto encontrado o null.
            return alumno;
        }
    }
}