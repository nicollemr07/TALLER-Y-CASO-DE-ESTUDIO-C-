using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA DE DOSIS ===");

        Console.Write("Nombre del paciente: ");
        string nombre = Console.ReadLine();

        Console.Write("Peso del paciente (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Dosis por kg (mg/kg): ");
        double dosisPorKg = double.Parse(Console.ReadLine());

        double dosis = CalcularDosis(peso, dosisPorKg);

        MostrarResultado(nombre, dosis);
    }

    // Método que calcula la dosis
    static double CalcularDosis(double peso, double dosisPorKg)
    {
        return peso * dosisPorKg;
    }

    // Método que muestra el resultado
    static void MostrarResultado(string nombre, double dosis)
    {
        Console.WriteLine("\n=== RESULTADO ===");
        Console.WriteLine("Paciente: " + nombre);
        Console.WriteLine("Dosis recomendada: " + dosis + " mg");
    }
}
