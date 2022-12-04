using System.Net;
using Etapa1.Entidades;

public static class Program
{
    public static void Main(string [] args)
    {
        Escuela escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");

        Console.WriteLine(escuela);

        Curso curso1 = new Curso()
        {
            Nombre = "101"
        };

        Curso curso2 = new Curso()
        {
            Nombre = "201"
        };

        Curso curso3 = new Curso()
        {
            Nombre = "301"
        };

        Console.WriteLine(escuela);
        Console.WriteLine("===============");
        Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
        Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
        Console.WriteLine(curso3);

        System.Console.WriteLine("Arreglos");

        var arregloCurso = new Curso[3];

        arregloCurso[0] = new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana };
        arregloCurso[1] = new Curso() { Nombre = "201", Jornada = TiposJornada.Noche };
        arregloCurso[2] = new Curso() { Nombre = "301", Jornada = TiposJornada.Tarde };

        for (int i = 0; i < arregloCurso.Length; i++)
        {
            Console.WriteLine($"Nombre escuela: {arregloCurso[i].Nombre}, Id: {arregloCurso[i].UniqueId}");
        }

        System.Console.WriteLine("Arreglos linea por linea");
        System.Console.WriteLine("===============");
        Console.WriteLine(arregloCurso[0].Nombre + ", " + arregloCurso[0].UniqueId);
        Console.WriteLine($"{arregloCurso[1].Nombre}, {arregloCurso[1].UniqueId}");
        Console.WriteLine(arregloCurso[2]);

        System.Console.WriteLine("Colecciones");

        System.Console.WriteLine("======Por for=========");
        Curso.ImprimirFor(arregloCurso);
        System.Console.WriteLine("===============");
        System.Console.WriteLine("======Por foreach=========");
        Curso.ImprimirForEach(arregloCurso);
        System.Console.WriteLine("===============");
        System.Console.WriteLine("======Por while=========");
        Curso.ImprimirWhile(arregloCurso);
        System.Console.WriteLine("===============");
        System.Console.WriteLine("======Por do while=========");
        Curso.ImprimirDoWhile(arregloCurso);

    }

}







