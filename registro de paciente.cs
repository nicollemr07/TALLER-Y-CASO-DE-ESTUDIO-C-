using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== REGISTRO DE PACIENTE ===");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Estatura (m): ");
        double estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Tiene seguro? (S/N): ");
        string seguroInput = Console.ReadLine().ToUpper();
        bool tieneSeguro = seguroInput == "S";

        double imc = peso / (estatura * estatura);

        Console.WriteLine("\n=== FICHA MÉDICA ===");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad + " años");
        Console.WriteLine("Peso: " + peso + " kg");
        Console.WriteLine("Estatura: " + estatura + " m");
        Console.WriteLine("Seguro: " + (tieneSeguro ? "Sí" : "No"));
        Console.WriteLine("IMC: " + imc.ToString("0.00"));
    }
}
