using System.Net;
using Etapa1.Entidades;
using System.Collections.Generic;
using static System.Console;    //imprimir solo con WriteLine, sin Console.WriteLine

public static class Program
{
    public static void Main(string[] args)
    {
        Escuela escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

        escuela.ListaCursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Tarde },
            };
        
        var otra_coleccion = new List<Curso>() 
            {
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "Python for dummies", Jornada = TiposJornada.Tarde },
            };     

    }
    private static bool Predicado(Curso curobj)  //es como un apuntador a una funcion
    {
        return curobj.Nombre == "301"; //eliminar todos los cursos con nombre 301
    }
  
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        WriteLine("==============");
        WriteLine("Cursos de la Escuela");
        WriteLine("==============");
        if (escuela?.ListaCursos != null)
        {
            foreach (var curso in escuela.ListaCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Jornada: {curso.Jornada}, Id: {curso.UniqueId}");
            }
        }
    }
}







