using System.Net;
using Etapa1.Entidades;
using System.Collections.Generic;
using static System.Console;    //imprimir solo con WriteLine, sin Console.WriteLine

public static class Program
{
    public static void Main(string[] args)
    {
       
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







