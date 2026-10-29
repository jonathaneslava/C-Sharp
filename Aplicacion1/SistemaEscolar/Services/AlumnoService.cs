using SistemaEscolar.Data;
using SistemaEscolar.Models;

namespace SistemaEscolar.Services
{
    //Se crea la clase AlumnoService
    public class AlumnoService
    {
        //SistemaEscolarContext es el contexto que configuramos para acceder a SQL Server.
        //_context es el campo donde guardaremos la referencia a ese contexto.
        private readonly SistemaEscolarContext _context;
        //El constructor recibe el contexto automáticamente mediante la inyección de dependencias, porque ya registramos AddDbContext en Program.cs.
        public AlumnoService(SistemaEscolarContext context)
        {
            _context = context;
        }

        // Busca un alumno utilizando su identificador.
        public Alumnos? ObtenerAlumnoPorId(int id)
        {
            // Buscamos al alumno en SQL Server por su Id.
            Alumnos? alumno = _context.Alumnos.Find(id);

            // Si no existe, devolvemos null.
            return alumno;
        }

        //Este método devuelve una lista de objetos Alumnos
        public List<Alumnos> ObtenerAlumnos()
        {
            return _context.Alumnos.ToList();
        }

        public Alumnos RegistrarAlumno(Alumnos nuevoAlumno)
        {
            // Agrega el alumno al contexto de EF Core.
            _context.Alumnos.Add(nuevoAlumno);

            // Guarda los cambios en SQL Server.
            _context.SaveChanges();

            // Devuelve el alumno registrado, incluyendo su Id generado.
            return nuevoAlumno;
        }

        public Alumnos? ActualizarAlumno(int id, Alumnos alumnoActualizado)
        {
            // Buscamos al alumno en la base de datos.
            Alumnos? alumno = _context.Alumnos.Find(id);

            // Si no existe, devolvemos null.
            if (alumno == null)
            {
                return null;
            }

            // Actualizamos sus propiedades.
            alumno.Nombre = alumnoActualizado.Nombre;
            alumno.Edad = alumnoActualizado.Edad;
            alumno.Carrera = alumnoActualizado.Carrera;
            alumno.Correo = alumnoActualizado.Correo;

            // Guardamos los cambios en SQL Server.
            _context.SaveChanges();

            return alumno;
        }

        public bool EliminarAlumno(int id)
        {
            // Buscamos al alumno en la base de datos.
            Alumnos? alumno = _context.Alumnos.Find(id);

            // Si no existe, indicamos que no se pudo eliminar.
            if (alumno == null)
            {
                return false;
            }

            // Marcamos al alumno para eliminarlo.
            _context.Alumnos.Remove(alumno);

            // Guardamos la eliminación en SQL Server.
            _context.SaveChanges();

            return true;
        }

    }
}