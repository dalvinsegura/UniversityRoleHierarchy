using System;
using System.Collections.Generic;

public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public string ID { get; set; }

    public MiembroDeLaComunidad(string nombre, string id)
    {
        Nombre = nombre;
        ID = id;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, ID: {ID}");
    }
}

public class Empleado : MiembroDeLaComunidad
{
    public Empleado(string nombre, string id) : base(nombre, id) { }
}

public class Estudiante : MiembroDeLaComunidad
{
    public Estudiante(string nombre, string id) : base(nombre, id) { }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public ExAlumno(string nombre, string id) : base(nombre, id) { }
}

public class Docente : Empleado
{
    public Docente(string nombre, string id) : base(nombre, id) { }
}

public class Administrativo : Empleado
{
    public Administrativo(string nombre, string id) : base(nombre, id) { }
}

public class Administrador : Docente
{
    public Administrador(string nombre, string id) : base(nombre, id) { }
}

public class Maestro : Docente
{
    public Maestro(string nombre, string id) : base(nombre, id) { }
}

class Program
{
    static void Main(string[] args)
    {
        MiembroDeLaComunidad estudiante = new Estudiante("Juan Perez", "E123");
        MiembroDeLaComunidad exAlumno = new ExAlumno("Maria Lopez", "EX456");
        Empleado docente = new Docente("Carlos Gomez", "D789");
        Administrativo administrativo = new Administrativo("Ana Torres", "A012");
        Administrador administrador = new Administrador("Luis Ramirez", "AD345");
        Maestro maestro = new Maestro("Dalvin Segura", "M678");

        List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>
        {
            estudiante, exAlumno, docente, administrativo, administrador, maestro
        };

        foreach (var miembro in miembros)
        {
            miembro.MostrarInformacion();
        }
    }
}