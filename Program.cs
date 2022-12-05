using System.Net;
using Etapa1.Entidades;
using System.Collections.Generic;
using static System.Console;    //imprimir solo con WriteLine, sin Console.WriteLine
using App;
using Util;

public static class Program
{
    public static void Main(string[] args)
    {
        var engine = new EscuelaEngine();
        engine.Inicializar();

        Printer.DibujarTitulo("Welcome to the school");
        Printer.SonidoBeep();
        Printer.SonidoBeep(1000, cantidad:10); // asignando valores a la funcion
        ImprimirCursosEscuela(engine.Escuela);
        
        //invocar un metodo de la clase static
        // Printer.DibujarLinea(20);
        
       
    }

    //Metodos
    private static bool Predicado(Curso curobj)  //es como un apuntador a una funcion
    {
        return curobj.Nombre == "301"; //eliminar todos los cursos con nombre 301
    }
  
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        Printer.DibujarTitulo("Curso Escuela");

        if (escuela?.ListaCursos != null)
        {
            foreach (var curso in escuela.ListaCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Jornada: {curso.Jornada}, Id: {curso.UniqueId}");
            }
        }
    }
}







