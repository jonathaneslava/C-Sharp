using System;
/*Este codigo tiene como finalidad almacenar en un arreglo la cantidad de piezas vendidas, el usuario puede colocar las cantidades que quiera,
se debe de obtener la suma de la venta, el promedio, la venta maxima y la venta minima, apartir de los resultados
se le mostrara al usuario si las ventas fueron buenas o se necesita mejorar*/
class VentasTotalPorcentaje
{
    public static void Ventas()
    {
        Console.WriteLine("Escribe la cantidad de piezas vendidas: "); //Se le pide la cantidad total de piezas vendidas
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int venta = 0;
        Console.WriteLine("Cantidad de piezas vendidas: " + cantidad);
        int[] ventas = new int[cantidad];
        //El ciclo ayuda a pedirle al usuario las cantidades de las piezas vendidas, el usuario establece el limite
        for (int i=0; i<cantidad; i++)
        {
            Console.WriteLine("Escribe la cantidad");
            venta = Convert.ToInt32(Console.ReadLine());
            ventas[i] = venta; //Se almacenan las ventas en el arreglo
        }
        double SumaTotal = SumaVenta(ventas);//Se llama al metodo de sumatoria
        Console.WriteLine("Suma Total: " + SumaTotal);
        double prome = Promedio(ventas); //Se llama al metodo de promedio
        Console.WriteLine("Promedio Total: " + prome);

        int[] MaxMin = MayorMenor(ventas);
        Console.WriteLine("Valor Maximo de ventas: " + MaxMin[1]);//Se llama al metodo de mayor
        Console.WriteLine("Valor Minimo de ventas: " + MaxMin[0]);//Se llama al metodo de mayor
        
        if (prome > 1000)
        {
            Console.WriteLine("Excelente dia");
        } else if (prome >= 500 && prome <1000)
        {
            Console.WriteLine("Dia regular");
        } else
        {
            Console.WriteLine("Necesitamos mejorar");
        }
    }

    //Se realiza la suma total de las cantidades dadas
    public static double SumaVenta(int[]suma)
    {
        double cantidades = 0;
        //El ciclo ayuda a realizar la sumatoria
        for(int j=0; j<suma.Length; j++)
        {
            cantidades = suma[j] + cantidades;
        }
        return cantidades;
    }
    //Se realiza el promedio de la venta total
    public static double Promedio(int[] sum)
    {
        double prom = SumaVenta(sum); //Se llama al metodo de suma venta
        double promedia = prom / sum.Length; //Se obtiene el promedio
        return promedia;
    }

    //Se ordena el arreglo y retorna un arreglo con la venta mas alta y la mas baja
    public static int[ ]MayorMenor(int[]arreglo)
    {
        int aux = 0;
        for(int i=0; i<arreglo.Length-1; i++) //Este ciclo ayuda a rectificar que el arreglo este ordenado de inicio a fin
        {
            for(int j=0; j< arreglo.Length - 1; j++) //Este ciclo ayuda a colocar el numero mayor al final
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    aux = arreglo[j + 1];
                    arreglo[j + 1] = arreglo[j];
                    arreglo[j] = aux;
                }
            }
        }
        int[] mayorMenor = new int[2];
        mayorMenor[0] = arreglo[0];
        mayorMenor[1] = arreglo[arreglo.Length - 1];
        return mayorMenor;
    }
    
}