using System;
/*Este codigo tiene como finalidad obtener el monto total de una cuenta, la propina apartir de un porcentaje dado 
y dividir la cuenta entre las personas dadas*/
class ProgramaPropinas
{
    public static void Porcentaje()
    {
        double MontoTotal = NumeroPositivo("Escribe el total de la cuenta "); //Se llama al metodo para obtener un numero valido
        double PorcentajePropina = NumeroPositivo("Escribe el porcentaje de propina que deseas dejar "); //Se llama al metodo para obtener un numero valido

        /*Verifica que el numero de personas sea mayor a cero, en caso contrario se le muestra un mensaje al 
        usuario para que coloque un numero mayor a cero*/
        Console.WriteLine("Entre cuantas personas se divide la cuenta");
        int personas = Convert.ToInt32(Console.ReadLine());
        while (personas <= 0)
        {
            Console.WriteLine("Escribe un numero valido de personas");
            personas = Convert.ToInt32(Console.ReadLine());
        }

        double PropinaTotal = MontoTotal * (PorcentajePropina / 100); //Se calcula la propina
        double CuentaTotal = PropinaTotal + MontoTotal; //Se obtiene el monto total con la propina incluida
        double CuentaxPersona = CuentaTotal / personas; //Se divide la cuenta entre las personas dadas

        Console.WriteLine("Propina total " + PropinaTotal);
        Console.WriteLine("Cuenta Total " + CuentaTotal);
        Console.WriteLine("Cuenta por persona " + CuentaxPersona);

    }
    /*Verifica si los numeros colocados por el usuario son mayores que cero, en caso contrario se le manda un 
    mensaje al usuario hasta que coloque un numero mayor a cero y retorna el numero valido*/
    static double NumeroPositivo(string mensaje)
    {
        Console.WriteLine(mensaje);
        double cantidad = Convert.ToDouble(Console.ReadLine());
        while (cantidad <= 0)
        {
            Console.WriteLine("Escribe un numero valido");
            cantidad = Convert.ToDouble(Console.ReadLine());
        }
        return cantidad;

    }
}
