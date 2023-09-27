using System;

public class Numeropi
{
    public static void Main()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine();
        Console.Write("Truncando PI: ");
        double PI = Math.Truncate(Math.PI);
        Console.WriteLine(PI);

        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        Console.Write("Redondeando hacia arriba PI: ");
        double PI1 = Math.Ceiling(Math.PI);
        Console.WriteLine(PI1);

        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        Console.Write("Redondeando hacia abajo PI: ");
        double PI2 = Math.Floor(Math.PI);
        Console.WriteLine(PI2);

        Console.WriteLine();
        Console.WriteLine("--------------------------------");

    }
}

//Jose Roberto Orellana Rodriguez
