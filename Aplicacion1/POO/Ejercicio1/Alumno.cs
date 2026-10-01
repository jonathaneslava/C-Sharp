public class Alumno
{
    public string nombre;
    public int edad;
    public int calificacion;

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