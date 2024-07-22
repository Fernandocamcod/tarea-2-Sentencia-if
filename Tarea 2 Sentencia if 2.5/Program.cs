using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese la calificación numérica
        Console.Write("Ingrese la calificación numérica (0-100): ");
        int calificacion = int.Parse(Console.ReadLine());

        // Convertir la calificación numérica a letra
        char letraCalificacion;
        if (calificacion >= 90)
        {
            letraCalificacion = 'A';
        }
        else if (calificacion >= 80)
        {
            letraCalificacion = 'B';
        }
        else if (calificacion >= 70)
        {
            letraCalificacion = 'C';
        }
        else if (calificacion >= 60)
        {
            letraCalificacion = 'D';
        }
        else
        {
            letraCalificacion = 'F';
        }

        // Mostrar la calificación en letra
        Console.WriteLine("La calificación en letra es: " + letraCalificacion);

        Console.ReadKey(); // Espera a que el usuario presione una tecla.
    }
}