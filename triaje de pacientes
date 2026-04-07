using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CLASIFICACIÓN DE PACIENTE ===");

        Console.Write("Temperatura (°C): ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Presión sistólica: ");
        int presion = int.Parse(Console.ReadLine());

        if (temp > 39 || presion > 180)
        {
            Console.WriteLine("🔴 ROJO - CRÍTICO");
            Console.WriteLine("Atención inmediata requerida.");
        }
        else if (temp > 38 || presion > 140)
        {
            Console.WriteLine("🟡 AMARILLO - URGENTE");
            Console.WriteLine("Atender lo antes posible.");
        }
        else
        {
            Console.WriteLine("🟢 VERDE - ESTABLE");
            Console.WriteLine("Paciente en condición estable.");
        }
    }
}
