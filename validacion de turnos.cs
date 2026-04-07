using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE TURNOS ===");

        string continuar = "S";

        while (continuar.ToUpper() == "S")
        {
            int turno;

            Console.Write("Ingrese número de turno: ");
            turno = int.Parse(Console.ReadLine());

            while (turno <= 0)
            {
                Console.WriteLine("❌ Error: El turno debe ser mayor a 0.");
                Console.Write("Ingrese número de turno nuevamente: ");
                turno = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("✅ Turno registrado correctamente: " + turno);

            Console.Write("¿Desea continuar? (S/N): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("Sistema finalizado.");
    }
}
