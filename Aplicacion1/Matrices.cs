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
}