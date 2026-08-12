using System;
/*Este codigo tiene como finalidad registrar las calificaciones de varios alumnos en varias materias utilizando una matriz (int[,]).
 Una escuela necesita un programa para analizar las calificaciones de sus alumnos.*/
class Matrices
{
    public static void Matriz()
    {
        Console.WriteLine("Cuantos alumnos son");
        int alumnos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cuantas materias tiene cada alumno");
        int materias = Convert.ToInt32(Console.ReadLine());
        int[,] calificaciones = new int[alumnos, materias];
        int calificacion = 0;
        //Se llena la matriz con las calificaciones de cada alumno
        Console.WriteLine("Escriba las califiaciones");
        for (int i = 0; i < alumnos; i++)
        {
            Console.WriteLine("Alumno " + (i+1));
            for (int j = 0; j < materias; j++)
            {
                Console.WriteLine("Materia " + (j+1));
                calificacion = Convert.ToInt32(Console.ReadLine());
                calificaciones[i, j] = calificacion;
            }
        }
        int[,] muestraMatriz = MostrarMatriz(calificaciones);
        Console.WriteLine(muestraMatriz);
        Console.WriteLine("Escribe el alumno que quieras sacar el promedio");
        int alumnoPromedio = Convert.ToInt32(Console.ReadLine());
        double promedio = PromedioAlumno(calificaciones, alumnoPromedio);
        Console.WriteLine("El promedio del alumno " + alumnoPromedio + " es: " + promedio);
        Console.WriteLine("Escribe la materia que quieras sacar el promedio");
        int materiaPromedio = Convert.ToInt32(Console.ReadLine());
        double promedioMateria = PromedioMateria(calificaciones, materiaPromedio);
        Console.WriteLine("El promedio de la materia " + materiaPromedio + " es: " + promedioMateria);
        Console.WriteLine("La mayor Calificacion es: ");
        double altaCalificacion = MayorCalificacion(calificaciones);
        Console.WriteLine(altaCalificacion);
    }
    public static int[,] MostrarMatriz(int[,] calificaciones)
    {
        for(int i=0; i<calificaciones.GetLength(0); i++)
        {
            Console.Write("Alumno " + (i + 1));
            for(int j=0; j< calificaciones.GetLength(1); j++)
            {
                Console.Write(" " + calificaciones[i, j]);
            }
            Console.WriteLine("");
        }
        return calificaciones;
    }

    public static double PromedioAlumno(int[,] calificaciones, int alumno)
    {
        int suma = 0;
        double promedio = 0;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            if (alumno == i)
            {
                for (int j=0; j < calificaciones.GetLength(1); j++)
                {
                    suma = calificaciones[i,j] + suma;
                }
            }
        }
        promedio = suma / (calificaciones.GetLength(1));
        return promedio;
    }

    public static double PromedioMateria(int[,] calificaciones, int materia)
    {
        int suma = 0;
        double promedio = 0;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                if (materia == j)
                {
                    suma = calificaciones[i, j] + suma;
                    Console.WriteLine("  " + suma);
                }
                        
            }
        }
        promedio = suma / (calificaciones.GetLength(1));
        return promedio;
    }

    public static double MayorCalificacion(int[,] calificaciones)
    {
        int aux = 0;
        int cont = 0;
        double mayorCalificacion = 0;
        int[] mayoresCalificaciones = new int[calificaciones.GetLength(0)];
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                if (calificaciones[i, j] > calificaciones[i, j + 1])
                {
                    aux = calificaciones[i, j + 1];
                    calificaciones[i, j + 1] = calificaciones[i, j];
                    calificaciones[i, j] = aux;
                }
            }
            mayoresCalificaciones[i] = calificaciones[i, calificaciones.GetLength(1)];
        }
        for (int k = 0; k < calificaciones.GetLength(0); k++)
        {
            if (mayoresCalificaciones[k] > mayoresCalificaciones[k + 1])
            {
                cont = mayoresCalificaciones[k + 1];
                mayoresCalificaciones[k + 1] = mayoresCalificaciones[k];
                mayoresCalificaciones[k] = cont;
            }
        }
        mayorCalificacion = mayoresCalificaciones[calificaciones.GetLength(0)];
        return mayorCalificacion;
        

    }
}