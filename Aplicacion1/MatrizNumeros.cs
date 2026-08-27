using System;
/*Este codigo tiene como finalidad realizar operaciones con una matriz, obtener suma de fila
 suma de columna, suma total, contar pares e impares, buscar numeros en la matriz y realizar
la transpuesta de la matriz*/
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
        Console.WriteLine("La suma de la columna " + columnaSuma + " es " + sumatoriaColumna);
        int sumaNumMatriz = SumaMatriz(matriz);
        Console.WriteLine("La suma de todos los elementos de la matriz es: " + sumaNumMatriz);
        int numPares = Pares(matriz);
        Console.WriteLine("Son " + numPares + " numeros pares en la matriz");
        int numImpares = Impares(matriz);
        Console.WriteLine("Son " + numImpares + " numeros impares en la matriz");
        Console.WriteLine("Escribe el numero que desees buscar en la matriz");
        int busca = Convert.ToInt32(Console.ReadLine());
        bool existe = BuscaNumero(matriz, busca);
        if (existe)
        {
            Console.WriteLine("El numero si existe en la matriz");
            BuscaNumeroPosicion(matriz, busca);
        }
        else
        {
            Console.WriteLine("El numero no existe en la matriz");
        }

        Console.WriteLine("La matriz transpuesta es: ");
        int[,] matrizTranspuesta = TransponerMatriz(matriz);
        MuestraMatriz(matrizTranspuesta);

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

    public static int SumaMatriz(int[,] matriz)
    {
        int sumatoria = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                sumatoria = matriz[i, j] + sumatoria;
            }
        }
        return sumatoria;
    }

    public static int Pares(int[,] matriz)
    {
        int contador = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    contador++;
                }
            }
        }
        return contador;
    }

    public static int Impares(int[,] matriz)
    {
        int contador = 0;
        for(int i=0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j]%2 != 0)
                {
                    contador++;
                }
            }
        }
        return contador;
    }
    public static bool BuscaNumero(int[,] matriz, int busca)
    {
        bool existe;
        int contador = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j] == busca)
                {
                    contador++;
                }
            }
        }
        if (contador != 0){
            existe = true;
        }
        else
        {
            existe = false;
        }
        return existe;
    }

    public static void BuscaNumeroPosicion(int[,] matriz, int busca)
    {
        for(int i=0; i < matriz.GetLength(0); i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == busca)
                {
                    Console.WriteLine("El numero esta en la posicion: [" + i + (" , ") + j + ("]"));
                }
            }
        }
    }

    public static int[,] TransponerMatriz(int[,] matriz)
    {
        int[,] transpuesta = new int[matriz.GetLength(1), matriz.GetLength(0)];
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }
        return transpuesta;
    }

}