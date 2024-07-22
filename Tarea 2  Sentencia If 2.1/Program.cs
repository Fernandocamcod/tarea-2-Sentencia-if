using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese tres valores enteros
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int num3 = int.Parse(Console.ReadLine());

        // Calcular la suma
        int suma = num1 + num2 + num3;

        // Calcular la media
        double media = (num1 + num2 + num3) / 3.0;

        // Mostrar los resultados
        Console.WriteLine("La suma de los tres números es: " + suma);
        Console.WriteLine("La media de los tres números es: " + media);

        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}
