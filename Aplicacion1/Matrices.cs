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
        int[,] calificacionesOriginales = new int[alumnos, materias];
        int calificacion = 0;
        //Se llena la matriz con las calificaciones de cada alumno
        Console.WriteLine("Escriba las calificaciones");
        for (int i = 0; i < alumnos; i++)
        {
            Console.WriteLine("Alumno " + (i+1));
            for (int j = 0; j < materias; j++)
            {
                Console.WriteLine("Materia " + (j+1));
                calificacion = Convert.ToInt32(Console.ReadLine());
                calificacionesOriginales[i, j] = calificacion;
            }
        }

        //Se crea una matriz de copia para no afectar la matriz original
        int[,] calificaciones = new int[alumnos, materias];
        for (int k = 0; k < calificacionesOriginales.GetLength(0); k++)
        {
            for (int l = 0; l < calificacionesOriginales.GetLength(1); l++)
            {
                calificaciones[k, l] = calificacionesOriginales[k, l];
            }
        }

        int[,] muestraMatriz = MostrarMatriz(calificaciones);
        Console.WriteLine(muestraMatriz);
        Console.WriteLine("Escribe el alumno que quieras sacar el promedio");
        int alumnoPromedio = Convert.ToInt32(Console.ReadLine());
        double promedio = PromedioAlumno(calificaciones, alumnoPromedio-1);
        Console.WriteLine("El promedio del alumno " + alumnoPromedio + " es: " + promedio);
        Console.WriteLine("Escribe la materia que quieras sacar el promedio");
        int materiaPromedio = Convert.ToInt32(Console.ReadLine());
        double promedioMateria = PromedioMateria(calificaciones, materiaPromedio-1);
        Console.WriteLine("El promedio de la materia " + materiaPromedio + " es: " + promedioMateria);
        double altaCalificacion = MayorCalificacion(calificaciones);
        Console.WriteLine("La calificacion mas alta es: " + altaCalificacion);
        double bajaCalificacion = MenorCalificacion(calificaciones);
        Console.WriteLine("La calificacion mas baja es: " + bajaCalificacion);
        int calificacionesAprobadas = CalificacionesAprobatorias(calificaciones);
        Console.WriteLine("La cantidad de calificaciones aprobatorias son: " + calificacionesAprobadas);
        int calificacionesReprobadas = CalificacionesReprobatorias(calificaciones);
        Console.WriteLine("La cantidad de calificaciones reprobatorias son: " + calificacionesReprobadas);
        Console.WriteLine("Escriba la calificacion que desea buscar");
        double calificacionBuscar = Convert.ToDouble(Console.ReadLine());
        bool existeCalificacion = BuscaCalificacion(calificaciones, calificacionBuscar);
        if (existeCalificacion)
        {
            Console.WriteLine("La calificacion existe en la matriz");
        }
        else
        {
            Console.WriteLine("La calificacion no existe en la matriz");
        }
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
                    //Console.WriteLine("  " + suma);
                }         
            }
        }
        promedio = suma / (calificaciones.GetLength(0));
        return promedio;
    }

    public static double MayorCalificacion(int[,] calificaciones)
    {
        int aux = 0;
        double mayorCalificacion = 0;
        int[] mayoresCalificaciones = new int[calificaciones.GetLength(0)];
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1) - 1; j++)
            {
                if (calificaciones[i, j] > calificaciones[i, j + 1])
                {
                    aux = calificaciones[i, j + 1];
                    calificaciones[i, j + 1] = calificaciones[i, j];
                    calificaciones[i, j] = aux;
                }
            }
        }
        //MostrarMatriz(calificaciones);
        int auxi = 0;
        for (int k = 0; k < calificaciones.GetLength(0)-1; k++) 
        {
            if (calificaciones[k, calificaciones.GetLength(1) - 1] > calificaciones[k + 1, calificaciones.GetLength(1) - 1])
            {
                auxi = calificaciones[k + 1, calificaciones.GetLength(1) - 1];
                calificaciones[k + 1, calificaciones.GetLength(1) - 1] = calificaciones[k, calificaciones.GetLength(1) - 1];
                calificaciones[k, calificaciones.GetLength(1) - 1] = auxi;
            }
        }
        //MostrarMatriz(calificaciones);
        mayorCalificacion = calificaciones[calificaciones.GetLength(0) - 1, calificaciones.GetLength(1) - 1];
        return mayorCalificacion;
    }

    public static double MenorCalificacion(int[,] calificaciones)
    {
        int aux = 0;
        double menorCalificacion = 0;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1) - 1; j++)
            {
                if (calificaciones[i, j] < calificaciones[i, j + 1])
                {
                    aux = calificaciones[i, j + 1];
                    calificaciones[i, j + 1] = calificaciones[i, j];
                    calificaciones[i, j] = aux;
                }
            }
        }
        //MostrarMatriz(calificaciones);
        int auxi = 0;
        for (int k = 0; k < calificaciones.GetLength(0) - 1; k++)
        {
            if (calificaciones[k, calificaciones.GetLength(1) - 1] < calificaciones[k + 1, calificaciones.GetLength(1) - 1])
            {
                auxi = calificaciones[k + 1, calificaciones.GetLength(1) - 1];
                calificaciones[k + 1, calificaciones.GetLength(1) - 1] = calificaciones[k, calificaciones.GetLength(1) - 1];
                calificaciones[k, calificaciones.GetLength(1) - 1] = auxi;
            }
        }
        //MostrarMatriz(calificaciones);
        menorCalificacion = calificaciones[calificaciones.GetLength(0) - 1, calificaciones.GetLength(1) - 1];
        return menorCalificacion;
    }

    public static int CalificacionesAprobatorias(int[,] calificaciones)
    {
        int calAprobadas=0;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                if (calificaciones[i, j] >= 7)
                {
                    calAprobadas++;
                }
            }
        }
        return calAprobadas;
    }

    public static int CalificacionesReprobatorias(int[,] calificaciones)
    {
        int calReprobadas = 0;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                if (calificaciones[i, j] < 7)
                {
                    calReprobadas++;
                }
            }
        }
        return calReprobadas;
    }

    public static bool BuscaCalificacion(int[,] calificaciones, double busca)
    {
        int contador = 0;
        bool existe;
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                if (calificaciones[i, j] == busca)
                {
                    contador++;
                }
            }
        }
        if(contador != 0)
        {
            existe = true;
        }
        else
        {
            existe = false;
        }
        return existe;
    }

}