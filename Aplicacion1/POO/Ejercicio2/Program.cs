using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cuantos alumnos desea registrar");
        int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());
        Alumno[] alumnos = new Alumno[cantidadAlumnos];
        string nombre;
        int edad;
        int calificacion;

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            Console.WriteLine("Datos Alumno: " + (i + 1));
            Console.WriteLine("Escribe el nombre");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escribe la edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe la calificacion");
            calificacion = Convert.ToInt32(Console.ReadLine());
            Alumno alumno = new Alumno(nombre, edad, calificacion);
            alumnos[i] = alumno;
        }
        MuestraAlumnos(alumnos);
        double promedioAlumnos = PromedioAlumnos(alumnos);
        Console.WriteLine("El promedio de los alumnos es: " + promedioAlumnos);
        Alumno mayorCalificacion = ObtenerMayorCalificacion(alumnos);
        Console.WriteLine("El alumno con la mayor calificacion es: ");
        Console.WriteLine("Nombre:" + mayorCalificacion.nombre);
        Console.WriteLine("Edad: " + mayorCalificacion.edad);
        Console.WriteLine("Calificacion: " + mayorCalificacion.calificacion);
        Console.WriteLine("============================================");
        int alumnosAprobados = Aprobados(alumnos);
        Console.WriteLine("La cantidad de alumnos aprobados es: " + alumnosAprobados);
        int alumnosReprobados = Reprobados(alumnos);
        Console.WriteLine("La cantidad de alumnos reprobados es: "+alumnosReprobados);
        Console.WriteLine("Escribe el nombre que desees buscar");
        string buscaNombre = Convert.ToString(Console.ReadLine());
        bool existeNombre = existe(alumnos, buscaNombre);
        if (existeNombre)
        {
            Console.WriteLine("Si existe!!!");
            MuestraAlumnoExiste(alumnos, buscaNombre);
        }
        else
        {
            Console.WriteLine("No existe ese nombre o se escribio de forma incorrecta");
        }
        Console.WriteLine("Escribe la edad que desees buscar");
        int buscaEdad = Convert.ToInt32(Console.ReadLine());
        MuestraAlumnos(Edades(alumnos, buscaEdad));

        //Se llama al metodo MostrarDatos de la clase Alumno
        Console.WriteLine("Entrara al metodo de Alumno Mostrar Datos");
        for (int a = 0; a < alumnos.Length; a++)
        {
            alumnos[a].MostrarDatos();
        }

        Console.WriteLine("Entrara al metodo de Esta Aprobado");
        for(int b = 0; b < alumnos.Length; b++)
        {
            if (alumnos[b].EstaAprobado())
            {
                Console.WriteLine("Esta aprobado el alumno: " + alumnos[b].nombre);
            }
            else
            {
                Console.WriteLine("Esta reprobado el alumno: " + alumnos[b].nombre);
            }
        }

        Console.WriteLine("Entrara al metodo de Obtener Estado");
        for(int c=0; c < alumnos.Length; c++)
        {
            Console.WriteLine("El alumno: " + alumnos[c].nombre + " esta " + alumnos[c].ObtenerEstado());
        }

        Console.WriteLine("Entra al metodo de Puede Subir Clificacion");
        Console.WriteLine("¿Que alumno quiere revisar si puede subir su calificacion");
        int alumnoSubeCalificacion = Convert.ToInt32(Console.ReadLine());
        if (alumnoSubeCalificacion <= 0 || alumnoSubeCalificacion > cantidadAlumnos)
        {
            Console.WriteLine("El alumno no existe");
        }
        else
        {
            Alumno alumnoSube = alumnos[alumnoSubeCalificacion - 1];
            if (alumnoSube.PuedeSubirCalificacion())
            {
                Console.WriteLine("El alumno puede subir calificacion");
                Console.WriteLine("Cuantos puntos subira el alumno?");
                int subirPuntos = Convert.ToInt32(Console.ReadLine());
                alumnoSube.SubirCalificacion(subirPuntos);
                alumnoSube.MostrarDatos();
            }
            else
            {
                Console.WriteLine("El alumno no puede subir su calificacion");
            }
        }

            Console.ReadKey();
    }

    public static void MuestraAlumnos(Alumno[] alumnos)
    {
        for (int i = 0; i < alumnos.Length; i++)
        {
            Console.WriteLine("Alumno:" + (i + 1));
            Console.WriteLine("Nombre: " + alumnos[i].nombre);
            Console.WriteLine("Edad: " + alumnos[i].edad);
            Console.WriteLine("Calificacion: " + alumnos[i].calificacion);
            Console.WriteLine("=========================================");
        }
    }

    public static double PromedioAlumnos(Alumno[] alumnos)
    {
        double suma = 0;
        double promedio = 0;
        for (int i = 0; i < alumnos.Length; i++)
        {
            suma = alumnos[i].calificacion + suma;
        }
        promedio = suma / alumnos.Length;
        return promedio;
    }

    public static Alumno ObtenerMayorCalificacion(Alumno[] alumnos)
    {
        Alumno[] alumnosCopia = new Alumno[alumnos.Length];

        for (int k = 0; k < alumnos.Length; k++)
        {
            alumnosCopia[k] = alumnos[k];
        }
        Alumno aux;
        for (int i = 0; i < alumnosCopia.Length-1; i++)
        {
            for (int j = 0; j < alumnosCopia.Length - 1; j++)
            {
                if (alumnosCopia[j].calificacion > alumnosCopia[j + 1].calificacion)
                {
                    aux = alumnosCopia[j + 1];
                    alumnosCopia[j + 1] = alumnosCopia[j];
                    alumnosCopia[j] = aux;
                }
            }
        }
        return alumnosCopia[alumnosCopia.Length - 1];
    }

    public static int Aprobados(Alumno[] alumnos)
    {
        int contador = 0;
        for (int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i].calificacion >= 7)
            {
                contador++;
            }
        }
        return contador;
    }

    public static int Reprobados(Alumno[] alumnos)
    {
        int contador = 0;
        for(int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i].calificacion < 7)
            {
                contador++;
            }
        }
        return contador;
    }

    public static bool existe(Alumno[] alumnos, string buscaNombre)
    {
        for(int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i].nombre == buscaNombre)
            {
                return true;
            }
        }
        return false;
    }

    public static void MuestraAlumnoExiste(Alumno[] alumnos, string buscaNombre)
    {
        for(int i=0; i < alumnos.Length; i++)
        {
            if (alumnos[i].nombre == buscaNombre)
            {
                Console.WriteLine("Nombre: " + alumnos[i].nombre);
                Console.WriteLine("Edad " + alumnos[i].edad);
                Console.WriteLine("Calificacion " + alumnos[i].calificacion);
                Console.WriteLine("=========================");
            }
        }
    }

    public static Alumno[] Edades(Alumno[] alumnos, int edad)
    {
        int contador = 0;
        int posicion = 0;
        for(int j=0; j < alumnos.Length; j++)
        {
            if (alumnos[j].edad == edad)
            {
                contador++;
            }
        }
        Alumno[] edadAlumno = new Alumno[contador];
        if (contador > 0)
        {
            for(int i=0; i < alumnos.Length; i++)
            {
                if (alumnos[i].edad == edad)
                {
                    edadAlumno[posicion] = alumnos[i];
                    posicion++;
                }
            }
        }
        return edadAlumno;
    }
}


