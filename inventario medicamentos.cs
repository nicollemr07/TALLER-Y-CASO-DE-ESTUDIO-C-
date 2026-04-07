using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== INVENTARIO DE MEDICAMENTOS ===");

        string[] nombres = new string[5];
        int[] cantidades = new int[5];

        // Llenar los arreglos
        for (int i = 0; i < 5; i++)
        {
            Console.Write("\nIngrese nombre del medicamento #" + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            Console.Write("Cantidad disponible: ");
            cantidades[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar inventario
        Console.WriteLine("\n=== INVENTARIO COMPLETO ===");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nombres[i] + " - Stock: " + cantidades[i]);
        }

        // Buscar el menor stock
        int menor = cantidades[0];
        int posicion = 0;

        for (int i = 1; i < 5; i++)
        {
            if (cantidades[i] < menor)
            {
                menor = cantidades[i];
                posicion = i;
            }
        }

        Console.WriteLine("\n⚠️ Medicamento con menor stock:");
        Console.WriteLine(nombres[posicion] + " - Cantidad: " + menor);
    }
}
