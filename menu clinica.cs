using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MENÚ DE SERVICIOS ===");
        Console.WriteLine("1. Consulta");
        Console.WriteLine("2. Laboratorio");
        Console.WriteLine("3. Rayos X");
        Console.WriteLine("4. Farmacia");
        Console.WriteLine("5. Salir");

        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Consulta - Precio: $50 - Espera: 20 min");
                break;

            case 2:
                Console.WriteLine("Laboratorio - Precio: $80 - Espera: 40 min");
                break;

            case 3:
                Console.WriteLine("Rayos X - Precio: $120 - Espera: 30 min");
                break;

            case 4:
                Console.WriteLine("Farmacia - Precio variable - Espera: 10 min");
                break;

            case 5:
                Console.WriteLine("Saliendo del sistema...");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}
