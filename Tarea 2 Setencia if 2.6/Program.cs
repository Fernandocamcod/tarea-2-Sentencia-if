using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese un número del 1 al 7
        Console.Write("Ingrese un número del 1 al 7 para representar un día de la semana (1 para lunes, 2 para martes, etc.): ");
        int dia = int.Parse(Console.ReadLine());

        // Variable para almacenar el nombre del día
        string nombreDia;

        // Determinar el nombre del día según el número ingresado
        if (dia == 1)
        {
            nombreDia = "Lunes";
        }
        else if (dia == 2)
        {
            nombreDia = "Martes";
        }
        else if (dia == 3)
        {
            nombreDia = "Miércoles";
        }
        else if (dia == 4)
        {
            nombreDia = "Jueves";
        }
        else if (dia == 5)
        {
            nombreDia = "Viernes";
        }
        else if (dia == 6)
        {
            nombreDia = "Sábado";
        }
        else if (dia == 7)
        {
            nombreDia = "Domingo";
        }
        else
        {
            nombreDia = "Número inválido. Debe ser un número del 1 al 7.";
        }

        // Mostrar el nombre del día correspondiente
        Console.WriteLine("El día correspondiente es: " + nombreDia);

        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}