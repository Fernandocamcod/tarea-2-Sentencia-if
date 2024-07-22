using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese el coeficiente a
        Console.Write("Ingrese el valor de a: ");
        double a = double.Parse(Console.ReadLine()); // Convertir la entrada a tipo double

        // Pedir al usuario que ingrese el coeficiente b
        Console.Write("Ingrese el valor de b: ");
        double b = double.Parse(Console.ReadLine()); // Convertir la entrada a tipo double

        // Pedir al usuario que ingrese el coeficiente c
        Console.Write("Ingrese el valor de c: ");
        double c = double.Parse(Console.ReadLine()); // Convertir la entrada a tipo double

        // Calcular el discriminante usando la fórmula b^2 - 4ac
        double discriminante = b * b - 4 * a * c;

        // Verificar si la ecuación tiene soluciones reales
        if (discriminante < 0)
        {
            // Si el discriminante es negativo, no hay soluciones reales
            Console.WriteLine("La ecuación no tiene soluciones reales.");
        }
        else if (discriminante == 0)
        {
            // Si el discriminante es cero, hay una única solución real
            double raiz = -b / (2 * a); // Calcular la raíz única
            Console.WriteLine("La ecuación tiene una única solución real: x = " + raiz);
        }
        else
        {
            // Si el discriminante es positivo, hay dos soluciones reales
            double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a); // Calcular la primera raíz
            double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a); // Calcular la segunda raíz

            // Mostrar las dos soluciones reales
            Console.WriteLine("La ecuación tiene dos soluciones reales:");
            Console.WriteLine("x1 = " + raiz1); // Mostrar la primera raíz
            Console.WriteLine("x2 = " + raiz2); // Mostrar la segunda raíz
        }

        Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar el programa
    }
}