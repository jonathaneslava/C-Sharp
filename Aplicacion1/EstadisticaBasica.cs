using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
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
        int[] numeros = new int[cantidad];
        //El ciclo ayuda a pedirle al usuario los numeros que quiera ingresar en el arreglo, el usuario establece el limite
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Escribe el numero");
            numeroEscrito = Convert.ToInt32(Console.ReadLine());
            numeros[i] = numeroEscrito; //Se almacenan las ventas en el arreglo
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
        if (existeNumero == true)
        {
            Console.WriteLine("El numero SI existe en el arreglo");
            posicion = PosicionNumero(numeros, numeroBuscar);
            Console.WriteLine("El numero esta en la posicion: " + posicion);
        }
        else
        {
            Console.WriteLine("El numero NO existe en el arreglo");
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
        int[] arregloMod = arreglo;
        for (int j = 0; j < arregloMod.Length - 1; j++) //Este ciclo ayuda a colocar el numero mayor al final
        {
            if (arregloMod[j] > arregloMod[j + 1])
            {
                aux = arregloMod[j + 1];
                arregloMod[j + 1] = arregloMod[j];
                arregloMod[j] = aux;
            }
        }
        int mayor = arregloMod[arregloMod.Length - 1];
        return mayor;
    }

    public static int Menor(int[] arreglo)
    {
        int aux = 0;
        int[] arregloM = arreglo;
        for (int j = 0; j < arregloM.Length - 1; j++) //Este ciclo ayuda a colocar el numero mayor al final
        {
            if (arregloM[j] < arregloM[j + 1])
            {
                aux = arregloM[j + 1];
                arregloM[j + 1] = arregloM[j];
                arregloM[j] = aux;
            }
        }
        int menor = arregloM[arregloM.Length - 1];
        return menor;
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
        int contador=0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == busca)
            {
                contador = i;
            }
        }
        return contador;
    }

}