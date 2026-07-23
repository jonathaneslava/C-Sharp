using System;

class ProgramaPropinas
{
    public static void Porcentaje()
    {
        double MontoTotal = NumeroPositivo("Escribe el total de la cuenta ");
        double PorcentajePropina = NumeroPositivo("Escribe el porcentaje de propina que deseas dejar ");

        Console.WriteLine("Entre cuantas personas se divide la cuenta");
        int personas = Convert.ToInt32(Console.ReadLine());
        while (personas <= 0)
        {
            Console.WriteLine("Escribe un numero valido de personas");
            personas = Convert.ToInt32(Console.ReadLine());
        }

        double PropinaTotal = MontoTotal * (PorcentajePropina / 100);
        double CuentaTotal = PropinaTotal + MontoTotal;
        double CuentaxPersona = CuentaTotal / personas;

        Console.WriteLine("Propina total " + PropinaTotal);
        Console.WriteLine("Cuenta Total " + CuentaTotal);
        Console.WriteLine("Cuenta por persona " + CuentaxPersona);

        //Quita el path del repositorio, la ubicacion de donde esta el proyecto
        Console.ReadKey();

    }

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
