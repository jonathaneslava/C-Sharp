public class Alumno
{
    //Propiedades
    public string nombre { get; set; }
    public int edad { get; set; }
    private int privcalificacion; //Campo Privado
    public int calificacion
    {
        get
        {
            return privcalificacion;
        }
        set
        {
            if(value >= 0 && value <= 10)
            {
                privcalificacion = value;
            }
        }
    }

    public Alumno(string nombre,int edad, int calificacion)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.calificacion = calificacion;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: "+ nombre);
        Console.WriteLine("Edad: "+ edad);
        Console.WriteLine("Calificacion: " + calificacion);
    }

    public bool EstaAprobado()
    {
        if (calificacion >= 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string ObtenerEstado()
    {
        string estado;
        if(calificacion >= 7)
        {
            estado = "Aprobado";
        }
        else
        {
            estado = "Reprobado";
        }
        return estado;
    }

    public void SubirCalificacion(int puntos)
    {
        int calificacionTotal = calificacion + puntos;

        if(calificacionTotal > 10)
        {
            calificacion = 10;
        }
        else
        {
            calificacion = calificacionTotal;
        }
    }


}