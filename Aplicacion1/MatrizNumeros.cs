using System;
/*Este codigo tiene como finalidad registrar las calificaciones de varios alumnos en varias materias utilizando una matriz (int[,]).
 Una escuela necesita un programa para analizar las calificaciones de sus alumnos.*/
class MatrizNumeros
{
    public static void AnalizadorMatrizNumeros()
    {
        Console.WriteLine("Coloca el numero de filas para la matriz");
        int filas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Coloca el numero de columnas para la matriz");
        int columnas = Convert.ToInt32(Console.ReadLine());
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            Console.WriteLine("Fila " + (i + 1));
            for (int j = 0; j < columnas; j++)
            {
                Console.WriteLine("Columna " + (j + 1));
                int numero = Convert.ToInt32(Console.ReadLine());
                matriz[i, j] = numero;
            }
        }
        MuestraMatriz(matriz);
        Console.WriteLine("Escribe la fila que desees sumar");
        int filaSumatoria = Convert.ToInt32(Console.ReadLine());
        int sumatoria = SumaFila(matriz, (filaSumatoria - 1));
        Console.WriteLine("La suma de la fila " + filaSumatoria + " es " + sumatoria);
        Console.WriteLine("Escribe la columna que desees sumar");
        int columnaSuma = Convert.ToInt32(Console.ReadLine());
        int sumatoriaColumna = SumaColumna(matriz, (columnaSuma-1));
        Console.WriteLine("La suma de la columna " + sumatoriaColumna + " es " + sumatoriaColumna);
    }
    public static void MuestraMatriz(int[,] matriz)
    {
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine("");
        }
    }

    public static int SumaFila(int[,] matriz, int filaSumatoria)
    {
        int sumatoria = 0;
        for(int i = 0; i < matriz.GetLength(1); i++)
        {
            sumatoria = matriz[filaSumatoria, i] + sumatoria;
        }
        return sumatoria;
    }

    public static int SumaColumna(int[,] matriz, int columnaSuma)
    {
        int sumatoria = 0;
        for(int i = 0;  i <matriz.GetLength(0); i++)
        {
            sumatoria = matriz[i, columnaSuma] + sumatoria;
        }
        return sumatoria;
    }
}