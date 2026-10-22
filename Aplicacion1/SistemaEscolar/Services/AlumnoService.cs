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

        public Alumnos? ActualizarAlumno(int id, Alumnos alumnoActualizado)
        {
            //Busca en la lista al alumno cuyo Id coincida con el que recibimos.
            Alumnos? alumno = alumnos.Find(a => a.Id == id);

            //Si no encuentra al alumno devuelve null
            if (alumno == null)
            {
                return null; //Devuelve null si no existe
            }
            //Asignacion de propiedades, copia los nuevos valores al alumno
            alumno.Nombre = alumnoActualizado.Nombre;
            alumno.Edad = alumnoActualizado.Edad;
            alumno.Carrera = alumnoActualizado.Carrera;
            //Devuelve el alumno actualizado.
            return alumno;
        }

        public bool EliminarAlumno(int id)
        {
            //Busca en la lista al alumno cuyo Id coincida con el que recibimos.
            Alumnos? alumno = alumnos.Find(a => a.Id == id);
            //Si no encuentra al alumno, devuelve false
            if (alumno == null)
            {
                return false;
            }
            //Si el alumno existe, lo elimina de la lista.
            alumnos.Remove(alumno);
            //Si lo eimino correctamente devuelve true.
            return true;
        }

    }
}