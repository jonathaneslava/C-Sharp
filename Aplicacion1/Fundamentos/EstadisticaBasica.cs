using System;
/*Este codigo tiene como finalidad almacenar en un arreglo la cantidad de numeros positivos y negativos que quiera el usuario,
se debe de obtener la suma, el promedio, el numero mayor, numero menor, cuantos numeros son positivos, negativos y ceros,
se le mostrara al usuario si un numero que el decida existe en el arreglo o no*/
class EstadisticaArreglo
{
    public static void Estadistica()
    {
        Console.WriteLine("Escribe la cantidad de numeros que deseas ingresar: "); //Se le pide la cantidad de numeros
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int numeroEscrito = 0;
        Console.WriteLine("Cantidad de numeros que ingreso: " + cantidad);
        int[] arregloOriginal = new int[cantidad];
        //El ciclo ayuda a pedirle al usuario los numeros que quiera ingresar en el arreglo, el usuario establece el limite
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Escribe el numero");
            numeroEscrito = Convert.ToInt32(Console.ReadLine());
            arregloOriginal[i] = numeroEscrito; //Se almacenan las ventas en el arreglo
        }
        int[] numeros = new int[cantidad];
        for (int j = 0; j < cantidad; j++)
        {
            numeros[j] = arregloOriginal[j];
        }
       
        double sumaTotal = SumaNumero(numeros);//Se llama al metodo para la sumatoria
        Console.WriteLine("Suma Total: " + sumaTotal);
        double promedioNumeros = Promedio(numeros); //Se llama al metodo de promedio
        Console.WriteLine("Promedio Total: " + promedioNumeros);

        int numeroMayor = Mayor(numeros);
        Console.WriteLine("El numero mayor en el arreglo es: " + numeroMayor);
        int numeroMenor = Menor(numeros);
        Console.WriteLine("El numero menor en el arreglo es: " + numeroMenor);
        int cantidadPositivos = ContarPositivos(numeros);
        Console.WriteLine("La cantidad de numeros positivos en el arreglo es: " + cantidadPositivos);
        int cantidadNegativos = ContarNegativos(numeros);
        Console.WriteLine("La cantidad de numeros negativos en el arreglo es: " + cantidadNegativos);
        int cantidadCeros = ContarCeros(numeros);
        Console.WriteLine("La cantidad de numeros ceros en el arreglo es: " + cantidadCeros);
        Console.WriteLine("Escribe un numero que desees buscar en el arreglo: ");
        int numeroBuscar = Convert.ToInt32(Console.ReadLine());
        bool existeNumero = BuscaNumero(numeros, numeroBuscar);
        int posicion;
        //Si existe el numero a buscar en el arreglo indica si o no ademas de la posicion donde se encuentra si existe
        if (existeNumero)
        {
            Console.WriteLine("El numero SI existe en el arreglo");
            posicion = PosicionNumero(numeros, numeroBuscar);
            Console.WriteLine("El numero esta en la posicion: " + posicion);
        }
        else
        {
            Console.WriteLine("El numero NO existe en el arreglo");
        }
        //Muestra la copia del arreglo
        Console.WriteLine("Copia del arreglo");
        for (int k = 0; k < cantidad; k++)
        {
            Console.WriteLine(numeros[k]);
        }
        //Muestra el arreglo original
        Console.WriteLine("Arreglo Original");
        for (int l = 0; l < cantidad; l++)
        {
            Console.WriteLine(arregloOriginal[l]);
        }
    }

    //Se realiza la suma total de las cantidades dadas
    public static double SumaNumero(int[] suma)
    {
        double cantidades = 0;
        //El ciclo ayuda a realizar la sumatoria
        for (int i = 0; i < suma.Length; i++)
        {
            cantidades = suma[i] + cantidades;
        }
        return cantidades;
    }
    //Se realiza el promedio de los numeros
    public static double Promedio(int[] suma)
    {
        double sumatoria = SumaNumero(suma); //Se llama al metodo de suma numeros 
        double promedia = sumatoria / suma.Length; //Se obtiene el promedio
        return promedia;
    }

    public static int Mayor(int[] arreglo)
    {
        int aux = 0;
        int numMayor=0;
        for (int i = 0; i < arreglo.Length - 1; i++) //Este ciclo ayuda a rectificar que el arreglo este ordenado de inicio a fin
        {
            for (int j = 0; j < arreglo.Length - 1; j++) //Este ciclo ayuda a colocar el numero mayor al final
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    aux = arreglo[j + 1];
                    arreglo[j + 1] = arreglo[j];
                    arreglo[j] = aux;
                }
            }
        }
        numMayor = arreglo[arreglo.Length - 1]; //Se coloca la ultima posicion por ser el numero mayor al ordenar el arreglo
        return numMayor;
    }

    public static int Menor(int[] arreglo)
    {
        int aux = 0;
        int numMenor = 0;
        for (int i = 0; i < arreglo.Length - 1; i++) //Este ciclo ayuda a rectificar que el arreglo este ordenado de inicio a fin
        {
            for (int j = 0; j < arreglo.Length - 1; j++) //Este ciclo ayuda a colocar el numero mayor al final
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    aux = arreglo[j + 1];
                    arreglo[j + 1] = arreglo[j];
                    arreglo[j] = aux;
                }
            }
        }
        numMenor = arreglo[0]; //Se coloca la posicion cero porque es el numero menor en el arreglo ordenado
        return numMenor;
    }

    public static int ContarPositivos(int[] arreglo) {
        int contadorPositivo = 0;
        for (int i=0; i<arreglo.Length; i++)
        {
            if (arreglo[i] > 0)
            {
                contadorPositivo++;
            }
        }
        return contadorPositivo;
    
    }

    public static int ContarNegativos(int[] arreglo)
    {
        int contadorNegativo = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] < 0)
            {
                contadorNegativo++;
            }
        }
        return contadorNegativo;

    }

    public static int ContarCeros(int[] arreglo)
    {
        int contadorCeros = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == 0)
            {
                contadorCeros++;
            }
        }
        return contadorCeros;

    }

    public static bool BuscaNumero(int[]arreglo, int busca)
    {
        int contador=0;
        bool existe;
        for(int i=0; i< arreglo.Length; i++)
        {
            if (arreglo[i] == busca)
            {
                contador++;
            }
        }
        if (contador != 0)
        {
            existe = true;
        }
        else
        {
            existe = false;
        }
        return existe;
    }

    public static int PosicionNumero(int[]arreglo,int busca)
    {
        int posicion=0;
        int i=0;
        while (arreglo[i] != busca)
        {
            i++;
        }
        posicion = i;;
        return posicion;
        
    }

}