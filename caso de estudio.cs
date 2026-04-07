using System;
using System.Collections.Generic;

// ===== INTERFAZ =====
interface IPersona
{
    int Id { get; set; }
    string Nombre { get; set; }
    string Email { get; set; }

    string ObtenerInfo();
}

// ===== CLASE ABSTRACTA =====
abstract class Persona : IPersona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public virtual string ObtenerInfo()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Email: {Email}";
    }
}

// ===== ESTUDIANTE =====
class Estudiante : Persona
{
    public string Programa { get; set; }
    public int Semestre { get; set; }

    public List<Inscripcion> Inscripciones = new List<Inscripcion>();

    public override string ObtenerInfo()
    {
        return base.ObtenerInfo() + $", Programa: {Programa}, Semestre: {Semestre}";
    }
}

// ===== DOCENTE =====
class Docente : Persona
{
    public string Titulo { get; set; }
    public string Departamento { get; set; }

    public List<Materia> Materias = new List<Materia>();
}

// ===== MATERIA =====
class Materia
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int Creditos { get; set; }
    public int Semestre { get; set; }
    public int CupoMax { get; set; }

    public Docente Docente { get; set; }

    public List<Inscripcion> Inscritos = new List<Inscripcion>();
}

// ===== INSCRIPCION =====
class Inscripcion
{
    public Estudiante Estudiante { get; set; }
    public Materia Materia { get; set; }
    public DateTime Fecha = DateTime.Now;
    public string Estado = "Activa";

    public Calificacion Calificacion { get; set; } // ✅ Guardar calificación
}

// ===== CALIFICACION =====
class Calificacion
{
    public Inscripcion Inscripcion { get; set; }

    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    public double Promedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

    public string Estado()
    {
        return Promedio() >= 3.0 ? "Aprobado" : "Reprobado";
    }
}

// ===== PROGRAMA PRINCIPAL =====
class Program
{
    static List<Estudiante> estudiantes = new List<Estudiante>();
    static List<Docente> docentes = new List<Docente>();
    static List<Materia> materias = new List<Materia>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- SISTEMA ACADEMICO ---");
            Console.WriteLine("1. Registrar estudiante");
            Console.WriteLine("2. Registrar docente");
            Console.WriteLine("3. Crear materia");
            Console.WriteLine("4. Inscribir estudiante");
            Console.WriteLine("5. Registrar notas");
            Console.WriteLine("6. Ver estudiantes");
            Console.WriteLine("7. Actualizar estudiante");
            Console.WriteLine("8. Eliminar estudiante");
            Console.WriteLine("9. Historial estudiante");
            Console.WriteLine("10. Inscritos por materia");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: RegistrarEstudiante(); break;
                case 2: RegistrarDocente(); break;
                case 3: CrearMateria(); break;
                case 4: Inscribir(); break;
                case 5: RegistrarNotas(); break;
                case 6: MostrarEstudiantes(); break;
                case 7: ActualizarEstudiante(); break;
                case 8: EliminarEstudiante(); break;
                case 9: HistorialEstudiante(); break;
                case 10: InscritosPorMateria(); break;
            }

        } while (opcion != 0);
    }

    // ===== ESTUDIANTES =====
    static void RegistrarEstudiante()
    {
        Estudiante e = new Estudiante();

        Console.Write("ID: ");
        e.Id = int.Parse(Console.ReadLine());

        Console.Write("Nombre: ");
        e.Nombre = Console.ReadLine();

        Console.Write("Email: ");
        e.Email = Console.ReadLine();

        Console.Write("Programa: ");
        e.Programa = Console.ReadLine();

        Console.Write("Semestre: ");
        e.Semestre = int.Parse(Console.ReadLine());

        estudiantes.Add(e);
        Console.WriteLine("Estudiante registrado");
    }

    static void ActualizarEstudiante()
    {
        Console.Write("ID estudiante: ");
        int id = int.Parse(Console.ReadLine());

        var e = estudiantes.Find(x => x.Id == id);

        if (e == null)
        {
            Console.WriteLine("No existe");
            return;
        }

        Console.Write("Nuevo nombre: ");
        e.Nombre = Console.ReadLine();

        Console.Write("Nuevo programa: ");
        e.Programa = Console.ReadLine();

        Console.Write("Nuevo semestre: ");
        e.Semestre = int.Parse(Console.ReadLine());

        Console.WriteLine("Estudiante actualizado");
    }

    static void EliminarEstudiante()
    {
        Console.Write("ID estudiante: ");
        int id = int.Parse(Console.ReadLine());

        var e = estudiantes.Find(x => x.Id == id);

        if (e != null)
        {
            estudiantes.Remove(e);
            Console.WriteLine("Estudiante eliminado");
        }
        else
        {
            Console.WriteLine("No existe");
        }
    }

    static void MostrarEstudiantes()
    {
        foreach (var e in estudiantes)
        {
            Console.WriteLine(e.ObtenerInfo());
        }
    }

    // ===== DOCENTES =====
    static void RegistrarDocente()
    {
        Docente d = new Docente();

        Console.Write("ID: ");
        d.Id = int.Parse(Console.ReadLine());

        Console.Write("Nombre: ");
        d.Nombre = Console.ReadLine();

        Console.Write("Email: ");
        d.Email = Console.ReadLine();

        Console.Write("Titulo: ");
        d.Titulo = Console.ReadLine();

        Console.Write("Departamento: ");
        d.Departamento = Console.ReadLine();

        docentes.Add(d);
        Console.WriteLine("Docente registrado");
    }

    // ===== MATERIAS =====
    static void CrearMateria()
    {
        Materia m = new Materia();

        Console.Write("Codigo: ");
        m.Codigo = Console.ReadLine();

        Console.Write("Nombre: ");
        m.Nombre = Console.ReadLine();

        Console.Write("Creditos: ");
        m.Creditos = int.Parse(Console.ReadLine());

        Console.Write("Semestre: ");
        m.Semestre = int.Parse(Console.ReadLine());

        Console.Write("Cupo maximo: ");
        m.CupoMax = int.Parse(Console.ReadLine());

        if (docentes.Count > 0)
        {
            Console.WriteLine("Docentes disponibles:");
            foreach (var d in docentes)
            {
                Console.WriteLine($"{d.Id} - {d.Nombre}");
            }

            Console.Write("Seleccione ID docente: ");
            int idDoc = int.Parse(Console.ReadLine());

            Docente doc = docentes.Find(x => x.Id == idDoc);

            if (doc != null)
            {
                m.Docente = doc;
                doc.Materias.Add(m);
            }
        }

        materias.Add(m);
        Console.WriteLine("Materia creada");
    }

    // ===== INSCRIPCIONES =====
    static void Inscribir()
    {
        if (estudiantes.Count == 0 || materias.Count == 0)
        {
            Console.WriteLine("Faltan datos");
            return;
        }

        Console.WriteLine("Estudiantes:");
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"{e.Id} - {e.Nombre}");
        }

        Console.Write("Ingrese ID estudiante: ");
        int id = int.Parse(Console.ReadLine());
        Estudiante est = estudiantes.Find(x => x.Id == id);

        Console.WriteLine("Materias:");
        foreach (var m in materias)
        {
            Console.WriteLine($"{m.Codigo} - {m.Nombre}");
        }

        Console.Write("Ingrese codigo materia: ");
        string cod = Console.ReadLine();
        Materia mat = materias.Find(x => x.Codigo == cod);

        if (est == null || mat == null)
        {
            Console.WriteLine("Datos incorrectos");
            return;
        }

        // Validar duplicado
        if (est.Inscripciones.Exists(x => x.Materia.Codigo == cod))
        {
            Console.WriteLine("Ya está inscrito en esta materia");
            return;
        }

        if (mat.Inscritos.Count >= mat.CupoMax)
        {
            Console.WriteLine("No hay cupo");
            return;
        }

        Inscripcion ins = new Inscripcion()
        {
            Estudiante = est,
            Materia = mat
        };

        est.Inscripciones.Add(ins);
        mat.Inscritos.Add(ins);

        Console.WriteLine("Inscripcion exitosa");
    }

    // ===== NOTAS =====
    static void RegistrarNotas()
    {
        Console.Write("ID estudiante: ");
        int id = int.Parse(Console.ReadLine());

        Estudiante e = estudiantes.Find(x => x.Id == id);

        if (e == null || e.Inscripciones.Count == 0)
        {
            Console.WriteLine("No hay inscripciones");
            return;
        }

        foreach (var ins in e.Inscripciones)
        {
            Console.WriteLine($"Materia: {ins.Materia.Nombre}");

            Calificacion c = new Calificacion();
            c.Inscripcion = ins;

            Console.Write("Nota 1: ");
            c.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            c.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            c.Nota3 = double.Parse(Console.ReadLine());

            ins.Calificacion = c;

            Console.WriteLine($"Promedio: {c.Promedio()} - {c.Estado()}");
        }
    }

    // ===== REPORTES =====
    static void HistorialEstudiante()
    {
        Console.Write("ID estudiante: ");
        int id = int.Parse(Console.ReadLine());

        var e = estudiantes.Find(x => x.Id == id);

        if (e == null)
        {
            Console.WriteLine("No existe");
            return;
        }

        Console.WriteLine($"\nHistorial de {e.Nombre}");

        foreach (var ins in e.Inscripciones)
        {
            if (ins.Calificacion != null)
            {
                Console.WriteLine($"{ins.Materia.Nombre} -> {ins.Calificacion.Promedio()} ({ins.Calificacion.Estado()})");
            }
            else
            {
                Console.WriteLine($"{ins.Materia.Nombre} -> Sin notas");
            }
        }
    }

    static void InscritosPorMateria()
    {
        Console.Write("Codigo materia: ");
        string cod = Console.ReadLine();

        var m = materias.Find(x => x.Codigo == cod);

        if (m == null)
        {
            Console.WriteLine("No existe");
            return;
        }

        Console.WriteLine($"\nInscritos en {m.Nombre}:");

        foreach (var ins in m.Inscritos)
        {
            Console.WriteLine(ins.Estudiante.Nombre);
        }
    }
}
