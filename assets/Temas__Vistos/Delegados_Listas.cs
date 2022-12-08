using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;    //imprimir solo con WriteLine, sin Console.WriteLine
using Etapa1.Entidades;

namespace Delegados
{
    public class Delegados_Listas
    {
        public static void listas()
        {
            Escuela escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

            escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
            };

            System.Console.WriteLine("Lista original: " + escuela.Cursos.Count());

            // add new elements
            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Mañana });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

            System.Console.WriteLine("Lista nuevos valores: " + escuela.Cursos.Count());

            var otra_coleccion = new List<Curso>() 
            {
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso() { Jornada = TiposJornada.Tarde },
            };

            // Curso tmp = new Curso() { Nombre = "101-Vacacional", Jornada = TiposJornada.Noche };

            // agregar dos colecciones en una sola 
            escuela.Cursos.AddRange(otra_coleccion);
            // escuela.ListaCursos.Add(tmp);
            // Console.WriteLine("Curso hash ->" + tmp.GetHashCode());
            ImprimirCursosEscuela(escuela);
            //otra_coleccion.Clear();

            // eliminar 
            // escuela.ListaCursos.Remove(otra_coleccion[0]);  //por index especifico
            // escuela.ListaCursos.Remove(tmp);  //por objeto especifico

            Predicate<Curso> miAlgoritmo = Predicado;  // delegado
            // escuela.ListaCursos.RemoveAll(Predicado);
            escuela.Cursos.RemoveAll(miAlgoritmo);  
            ImprimirCursosEscuela(escuela);
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
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Jornada: {curso.Jornada}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}