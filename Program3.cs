using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("Suma de Cuadrados");
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine();

        double n = 20; 
        double suma = 0; 
        double cuadrado = 0;

        for (int i = 1; i <= n; i++)
        {
            cuadrado = Math.Pow(i, 2); 
            suma += cuadrado; 
        }

        Console.WriteLine("La suma acumulada de los cuadrados de los primeros " + n + " números es: " + suma);
        Console.WriteLine("--------------------------------------------------------------------------------");
    }
}

//Jose Roberto Orellana Rodriguez