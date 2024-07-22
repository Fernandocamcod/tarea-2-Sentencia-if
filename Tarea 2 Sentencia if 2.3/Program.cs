using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese el primer número entero
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine()); // Convertir la entrada a tipo int

        // Pedir al usuario que ingrese el segundo número entero
        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine()); // Convertir la entrada a tipo int

        // Pedir al usuario que ingrese la operación aritmética
        Console.Write("Ingrese la operación (+, -, *, /): ");
        char operacion = Console.ReadKey().KeyChar; // Leer la operación ingresada por el usuario
        Console.WriteLine(); // Salto de línea para mejorar la legibilidad

        // Variable para almacenar el resultado
        double resultado = 0;

        // Realizar la operación según la opción elegida
        switch (operacion)
        {
            case '+':
                resultado = num1 + num2; // Sumar los dos números
                break;
            case '-':
                resultado = num1 - num2; // Restar el segundo número del primero
                break;
            case '*':
                resultado = num1 * num2; // Multiplicar los dos números
                break;
            case '/':
                // Verificar si el segundo número es cero para evitar división por cero
                if (num2 != 0)
                {
                    resultado = (double)num1 / num2; // Dividir el primer número por el segundo
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero."); // Mensaje de error
                    return; // Salir del programa
                }
                break;
            default:
                Console.WriteLine("Operación no válida. Por favor, use +, -, * o /."); // Mensaje de error
                return; // Salir del programa
        }

        // Mostrar el resultado de la operación
        Console.WriteLine("El resultado de la operación es: " + resultado);

        Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar el programa
    }
}