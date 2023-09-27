using System;
Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Ecuacion de Segundo grado");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

Console.Write("Ingrese el valor de A: ");
double A = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Ingrese el valor de B: ");
double B = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Ingrese el valor de C: ");
double C = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Implementando sus datos en la formula espere un momemento...");

double raiz = B * B  - 4 * A * C;
double x1 = (-B + Math.Sqrt(raiz)) / (2 * A);
double x2 = (-B - Math.Sqrt(raiz)) / (2 * A);

Console.WriteLine();
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Los resultados son");
Console.WriteLine();
Console.WriteLine("El valor de x1 es: " + x1);
Console.WriteLine();
Console.WriteLine("El valor de x2 es: " + x2);
Console.WriteLine("----------------------------------------------------------");

//Jose Roberto Orellana Rodriguez