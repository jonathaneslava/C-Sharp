//Permite utilizar clases necesarias de ASP.NET CORE crear un controller y manejar peticiones HTTP
using Microsoft.AspNetCore.Mvc;
//Permite utilizar la clase Alumnos que creamos dentro de la carpeta Models
using SistemaEscolar.Models;
using SistemaEscolar.Services;
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
        private readonly AlumnoService _alumnoService;
        //Es el constructor de la clase. Se ejecuta cuando se crea una instancia de AlumnosController
        //Obtiene la instancia registrada anteriormente mediante AddScoped.
        public AlumnosController(AlumnoService alumnoService)
        {
            //Guardamos esa instancia en el campo _alumnoService para poder utilizarla desde los métodos del Controller.
            _alumnoService = alumnoService;
        }

        // Indica que este método responderá a una petición HTTP GET (se utiliza normalmente para CONSULTAR información).
        // GET: api/Alumnos
        [HttpGet]
        public ActionResult<List<Alumnos>> ObtenerAlumnos()
        {
            //Devuelve una respuesta HTTP 200 OK junto con la lista de alumnos.
            return Ok(_alumnoService.ObtenerAlumnos());
        }

        //Documenta que el registro exitoso devuelve un alumno
        //ProducesResponseType informa que respuestas puede devolver un endpoint
        //typeof(Alumnos) Indica que la respuesta contiene un objeto de nuestra clase Alumnos
        //StatusCodes.Status201Created Representa el código HTTP 201, que indica que se creó un recurso
        //StatusCodes.Status400BadRequest Documenta el código 400, que indica que la solicitud tiene datos incorrectos o no puede procesarse como se esperaba.
        
        //con el código HTTP 201 Created.
        [ProducesResponseType(typeof(Alumnos), StatusCodes.Status201Created)]

        //Documenta que la solicitud puede ser incorrecta.
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        //Le indica a ASP.NET Core que este método debe ejecutarse cuando se recibe una petición HTTP POST.
        [HttpPost]
        public ActionResult<Alumnos> RegistrarAlumno(Alumnos nuevoAlumno) //El parámetro nuevoAlumno representa al alumno que recibimos. 
        {
            //nuevoAlumno contiene los datos que llegan desde Swagger.
            //_alumnoService.RegistrarAlumno(nuevoAlumno) solicita que el servicio registre al alumno.
            //alumnoRegistrado recibe el objeto que devuelve el servicio, incluido el identificador generado por SQL Server.
            Alumnos alumnoRegistrado =
                _alumnoService.RegistrarAlumno(nuevoAlumno);

            //Devuelve 201 Created e indica dónde consultar al alumno
            return CreatedAtAction( 
                nameof(ObtenerAlumnoPorId), //Indica qué método del controlador permite consultar al alumno creado GET.
                new { id = alumnoRegistrado.Id }, //Proporciona el ID que necesita ese método para construir la dirección URL.
                alumnoRegistrado //Es el objeto que queremos devolver en la respuesta, con sus datos y el ID que acabamos de asignarle.
            );
        }

        //Indica que este método recibe peticiones GET con un valor al final de la URL
        [HttpGet("{id}")]
        public ActionResult<Alumnos> ObtenerAlumnoPorId(int id)
        {
            //Le pide al Service que haga la búsqueda.
            Alumnos? alumno = _alumnoService.ObtenerAlumnoPorId(id);

            if (alumno == null)
            {
                return NotFound();
            }

            return Ok(alumno);
        }

        //Puede devolver 200 OK y, cuando lo haga, devolverá un objeto Alumnos
        [ProducesResponseType(typeof(Alumnos), StatusCodes.Status200OK)]
        //Puede responder 400 Bad Request si los datos enviados no son válidos
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //Puede devolver 404 Not Found si el alumno que buscamos no existe
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //Indica que este método responderá a solicitudes PUT que incluyan el identificador del alumno.
        [HttpPut("{id}")]
        //Recibe dos datos:id: identifica al alumno que queremos modificar. alumnoActualizado: contiene los nuevos datos que enviaremos.
        public ActionResult<Alumnos> ActualizarAlumno(int id, Alumnos alumnoActualizado)
        {
            //Solicita al Service que busque y actualice al alumno.
            Alumnos? alumno = _alumnoService.ActualizarAlumno(id, alumnoActualizado);

            //Si no encuentra al alumno devuelve null
            if (alumno == null)
            {
                return NotFound();//Responde con 404 not found
            }

            //Devuelve respuesta HTTP con los datos actualizados
            return Ok(alumno);
        }

        //Puede devolver 204 No Content cuando el alumno se elimina correctamente.
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //Puede devolver 404 Not Found si intentamos eliminar un alumno que no existe.
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //Indica que este método responderá a solicitudes HTTP DELETE
        //que incluyan el identificador del alumno.
        // DELETE: api/Alumnos/{id}
        [HttpDelete("{id}")]
        public IActionResult EliminarAlumno(int id)
        {
            //Solicita al Service que elimine al alumno y devuelve si tuvo éxito.
            bool eliminado = _alumnoService.EliminarAlumno(id);

            //Si no encuentra al alumno, devuelve una respuesta 404.
            if (!eliminado)
            {
                return NotFound();
            }

            //Devuelve una respuesta 204 indicando que la eliminación fue exitosa.
            return NoContent();
        }

    }
}