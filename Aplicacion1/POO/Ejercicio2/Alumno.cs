public class Alumno
{
    //Propiedades
    private string privnombre;
    public string nombre {
        get 
        {
            return privnombre; 
        
        }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("El nombre no debe de ser vacio");
            }
            else 
            {
                privnombre = value;
            }
        } 
    }

    private int privedad;
    public int edad {
        get 
        {
            return privedad;
        }
        set
        {
            if (value >= 5 && value <= 100)
            {
                privedad = value;
            }
            else 
            {
                Console.WriteLine("Edad no valida");
            }
        }   
    }

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
            else
            {
                Console.WriteLine("Calificacion no valida");
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

    public bool PuedeSubirCalificacion()
    {
        if(calificacion >= 10)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


}