using System;
/*Este codigo tiene como finalidad almacenar en un arreglo la cantidad de piezas vendidas, el usuario puede colocar las cantidades que quiera,
se debe de obtener la suma de la venta, el promedio, la venta maxima y la venta minima, apartir de los resultados
se le mostrara al usuario si las ventas fueron buenas o se necesita mejorar*/
class VentasTotalProcentaje
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
        double SumaTotal = SumaVenta(ventas, cantidad);//Se llama al metodo de sumatoria
        Console.WriteLine("Suma Total: " + SumaTotal);
        double prome = promedio(ventas, cantidad); //Se llama al metodo de promedio
        Console.WriteLine("Promedio Total: " + prome);
        int [] MaxMin = MayorMenor(ventas, cantidad);
        int max = MaxMin[cantidad-1];
        Console.WriteLine("Valor Maximo de ventas: " + max);//Se llama al metodo de mayor
        int min = MaxMin[0];
        Console.WriteLine("Valor Minimo de ventas: " + min);//Se llama al metodo de mayor
    }

    //Se realiza la suma total de las cantidades dadas
    public static double SumaVenta(int[]suma, int n)
    {
        double cantidades = 0;
        //El ciclo ayuda a realizar la sumatoria
        for(int j=0; j<n; j++)
        {
            cantidades = suma[j] + cantidades;
        }
        return cantidades;
    }
    //Se realiza el promedio de la venta total
    public static double promedio(int[] sum, int m)
    {
        double prom = 0;
        //Se realiza la sumatoria
        for (int k=0; k<m; k++)
        {
            prom = sum[k] + prom;
        }
        double promedia = prom / m; //Se obtiene el promedio
        return promedia;
    }

    //Se ordena el arreglo y retorna la venta mas alta
    public static int[ ]MayorMenor(int[]arreglo, int o)
    {
        int aux = 0;
        for(int i=0; i<o-1; i++) //Este ciclo ayuda a rectificar que el arreglo este ordenado de inicio a fin
        {
            for(int j=0; j<o-1; j++) //Este ciclo ayuda a colocar el numero mayor al final
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    aux = arreglo[i + 1];
                    arreglo[i + 1] = arreglo[i];
                    arreglo[i] = aux;
                }
            }
        }
        return arreglo;
    }
    
}