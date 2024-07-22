using System;

class CajeroAutomatico
{
    static void Main(string[] args)
    {
        // Saldo inicial del usuario
        double saldo = 1000.00; // Puedes modificar este valor según sea necesario

        Console.WriteLine("Bienvenido al Cajero Automático");
        Console.WriteLine($"Su saldo actual es: {saldo:C}"); // Muestra el saldo en formato de moneda

        // Solicitar al usuario la cantidad de dinero que desea retirar
        Console.Write("Ingrese la cantidad de dinero que desea retirar: ");
        double cantidadRetiro = double.Parse(Console.ReadLine().Replace(',', '.')); // Reemplazar la coma por un punto

        // Verificar si el saldo es suficiente
        if (cantidadRetiro <= saldo)
        {
            // Realizar la operación de retiro
            saldo -= cantidadRetiro; // Actualizar el saldo
            Console.WriteLine($"Retiro exitoso. Ha retirado: {cantidadRetiro:C}");
            Console.WriteLine($"Su nuevo saldo es: {saldo:C}"); // Mostrar el nuevo saldo
        }
        else
        {
            // Mensaje de error si no hay saldo suficiente
            Console.WriteLine("Error: Saldo insuficiente para realizar el retiro.");
            Console.WriteLine($"Su saldo actual es: {saldo:C}");
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}