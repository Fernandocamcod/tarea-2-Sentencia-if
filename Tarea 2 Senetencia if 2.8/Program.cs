using System;

class AdivinaElNumero
{
    static void Main(string[] args)
    {
        // Generar un número aleatorio entre 1 y 100
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // El rango es [1, 101), por lo que 101 no se incluye

        int intento = 0; // Variable para almacenar el número de intentos
        bool adivinado = false; // Variable para verificar si el número ha sido adivinado

        Console.WriteLine("¡Bienvenido al juego de Adivina el Número!");
        Console.WriteLine("He generado un número entre 1 y 100. ¡Intenta adivinarlo!");

        // Bucle hasta que el usuario adivine el número
        while (!adivinado)
        {
            // Pedir al usuario que ingrese un número
            Console.Write("Ingrese su intento: ");
            intento = int.Parse(Console.ReadLine());

            // Comparar el intento con el número aleatorio
            if (intento < numeroAleatorio)
            {
                Console.WriteLine("El número es mayor que " + intento + ".");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("El número es menor que " + intento + ".");
            }
            else
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número: " + numeroAleatorio);
                adivinado = true; // Cambiar el estado a adivinado
            }
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}