using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== INGRESO DE HISTORIA CLÍNICA ===");

        int historiaClinica = 0;
        bool datoValido = false;

        while (!datoValido)
        {
            try
            {
                Console.Write("Ingrese número de historia clínica: ");
                historiaClinica = int.Parse(Console.ReadLine());

                if (historiaClinica <= 0)
                {
                    Console.WriteLine("❌ El número debe ser mayor a 0.");
                }
                else
                {
                    datoValido = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Debe ingresar solo números, no texto.");
            }
        }

        Console.WriteLine("✅ Historia clínica registrada: " + historiaClinica);
    }
}
