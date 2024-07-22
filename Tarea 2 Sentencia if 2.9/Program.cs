using System;

class ProgramaDeVotacion
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese su edad
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine()); // Convertir la entrada a un número entero

        // Verificar si el usuario tiene la edad suficiente para votar
        if (edad >= 18)
        {
            Console.WriteLine("Usted puede votar.");
        }
        else
        {
            Console.WriteLine("Usted no puede votar.");
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}