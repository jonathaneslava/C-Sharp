//Permite utilizar clases necesarias de ASP.NET CORE crear un controller y manejar peticiones HTTP
using Microsoft.AspNetCore.Mvc;
//Permite utilizar la clase Alumnos que creamos dentro de la carpeta Models
using SistemaEscolar.Models;

//Indica el espacio de nombres al que pertenece esta clase SistemaEscolar trabaja con Controllers
namespace SistemaEscolar.Controllers 
{
    //Esta clase sera utilizada como un controlador de una API
    [ApiController]

    //Define la direccion URL de nuestro Controller. Como nuestra clase se llama: AlumnosController
    // la ruta resultante será: api/Alumnos
    [Route("api/[controller]")]

    public class AlumnosController : ControllerBase
    {
        //Lista temporal para hacer pruebas
        //Crea una lista capaz de contener varios objetos de tipo Alumnos
        private readonly List<Alumnos> alumnos = new List<Alumnos>
        {
            new Alumnos
            {
                Id = 1,
                Nombre = "Carlos",
                Edad = 20,
                Carrera = "Administracion"
            },
            new Alumnos
            {
                Id = 2,
                Nombre = "Pedro",
                Edad = 25,
                Carrera = "Medicina"
            }
        };

        // Indica que este método responderá a una petición HTTP GET (se utiliza normalmente para CONSULTAR información).
        // GET: api/Alumnos
        [HttpGet]
        public ActionResult<List<Alumnos>> ObtenerAlumnos()
        {
            //Devuelve una respuesta HTTP 200 OK junto con la lista de alumnos.
            return Ok(alumnos);
        }

        //Le indica a ASP.NET Core que este método debe ejecutarse cuando se recibe una petición HTTP POST.
        [HttpPost]
        public ActionResult<Alumnos> RegistrarAlumno(Alumnos nuevoAlumno) //El parámetro nuevoAlumno representa al alumno que recibimos. 
        {
            //Asigna un identificador tomando como referencia la cantidad de alumnos actuales.
            nuevoAlumno.Id = alumnos.Count + 1;

            //Agrega el objeto a nuestra lista.
            alumnos.Add(nuevoAlumno);

            //Devuelve el alumno registrado con una respuesta HTTP 200 OK.
            return Ok(nuevoAlumno);
        }

        //Indica que este método recibe peticiones GET con un valor al final de la URL
        [HttpGet("{id}")]
        public ActionResult<Alumnos> ObtenerAlumnoPorId(int id)
        {
            //Busca en la lista un alumno cuyo Id coincida con el que solicitaste.
            //Alumnos? indica el tipo de objeto que esperamos, permitiendo también que el resultado sea null si no se encuentra.
            //Expresion Lambda representa la condición que debe cumplir cada alumno para encontrarlo.
            Alumnos? alumno = alumnos.Find(a => a.Id == id);

            //Si no encuentra al alumno devuelve null
            if (alumno == null)
            {
                return NotFound(); //Responde con 404 not found
            }
            //Si el alumno existe devuelve sus datos
            return Ok(alumno);
        }

        //Indica que este método responderá a solicitudes PUT que incluyan el identificador del alumno.
        [HttpPut("{id}")]
        //Recibe dos datos:id: identifica al alumno que queremos modificar. alumnoActualizado: contiene los nuevos datos que enviaremos.
        public ActionResult<Alumnos> ActualizarAlumno(int id, Alumnos alumnoActualizado)
        {
            //Busca en la lista al alumno cuyo Id coincida con el que recibimos.
            Alumnos? alumno = alumnos.Find(a => a.Id == id);

            //Si no encuentra al alumno devuelve null
            if (alumno == null)
            {
                return NotFound();//Responde con 404 not found
            }

            //Asignacion de propiedades, copia los nuevos valores al alumno
            alumno.Nombre = alumnoActualizado.Nombre;
            alumno.Edad = alumnoActualizado.Edad;
            alumno.Carrera = alumnoActualizado.Carrera;

            //Devuelve respuesta HTTP con los datos actualizados
            return Ok(alumno);
        }

    }
}