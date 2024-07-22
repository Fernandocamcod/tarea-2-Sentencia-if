using System;
using System.Globalization;

class CalculadoraDeIMC
{
    static void Main(string[] args)
    {
        // Establecer la cultura para permitir el uso de coma como separador decimal
        CultureInfo culture = new CultureInfo("es-ES");

        // Mensaje de bienvenida
        Console.WriteLine("Bienvenido a la Calculadora de Índice de Masa Corporal (IMC)");

        // Pedir al usuario que ingrese su peso en kilogramos (use ',' para decimales)
        Console.Write("Ingrese su peso en kilogramos (use ',' para decimales): ");
        double peso = Convert.ToDouble(Console.ReadLine(), culture);

        // Pedir al usuario que ingrese su altura en metros (use ',' para decimales)
        Console.Write("Ingrese su altura en metros (use ',' para decimales): ");
        double altura = Convert.ToDouble(Console.ReadLine(), culture);

        // Calcular el IMC usando la fórmula: peso / (altura * altura)
        double imc = peso / (altura * altura);

        // Clasificar el estado de peso según el IMC
        string clasificacion;
        if (imc < 18.5)
        {
            clasificacion = "Bajo peso";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            clasificacion = "Peso normal";
        }
        else if (imc >= 25 && imc < 30)
        {
            clasificacion = "Sobrepeso";
        }
        else
        {
            clasificacion = "Obesidad";
        }

        // Mostrar los resultados
        Console.WriteLine($"Su IMC es: {imc:F2}"); // Mostrar el IMC con dos decimales
        Console.WriteLine("Clasificación: " + clasificacion);

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
