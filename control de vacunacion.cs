using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CONTROL DE VACUNACIÓN SEMANAL ===");

        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        int totalVacunas = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Vacunas aplicadas el " + dias[i] + ": ");
            int vacunasDia = int.Parse(Console.ReadLine());

            totalVacunas += vacunasDia;
        }

        double promedio = totalVacunas / 7.0;

        Console.WriteLine("\n=== REPORTE SEMANAL ===");
        Console.WriteLine("Total de vacunas aplicadas: " + totalVacunas);
        Console.WriteLine("Promedio diario: " + promedio.ToString("0.00"));
    }
}
