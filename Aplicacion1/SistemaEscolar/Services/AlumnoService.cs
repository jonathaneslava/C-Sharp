using SistemaEscolar.Models;

namespace SistemaEscolar.Services
{
    //Se crea la clase AlumnoService
    public class AlumnoService
    {
        //Por ahora utilizamos la misma lista temporal de alumnos.
        private readonly List<Alumnos> alumnos = new List<Alumnos>
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

        //Este método devuelve una lista de objetos Alumnos
        public List<Alumnos> ObtenerAlumnos()
        {
            return alumnos;//devuelve la lista que pertenece al Service.
        }

        private int siguienteId = 3;

        public Alumnos RegistrarAlumno(Alumnos nuevoAlumno)
        {
            //Asignamos un Id único al nuevo alumno.
            //Usando siguienteId++ nos permite incrementar de forma ordenada los ID aunque se eliminen alumnos de la lista.
            nuevoAlumno.Id = siguienteId++;
            //Agrega el objeto a nuestra lista.
            alumnos.Add(nuevoAlumno);
            //Devuelve al alumno registrado
            return nuevoAlumno;
        }

    }
}