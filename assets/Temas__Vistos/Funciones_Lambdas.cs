using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa1.Entidades;
using static System.Console;

namespace Lambdas
{
    public class Funciones_Lambdas
    {
        public static void LambasExamples()
        {
            Escuela escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");

            escuela.Cursos = new List<Curso>()
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

            escuela.Cursos.AddRange(otra_coleccion);
            //Predicado, forma de asiganar un delegado
            // escuela.Cursos.RemoveAll(Predicado);
            //Funciones lambda
            escuela.Cursos.RemoveAll(delegate (Curso curso)
                                        {
                                            return curso.Jornada == TiposJornada.Mañana;
                                        });
            //Funcion lambda con varios parametros
            escuela.Cursos.RemoveAll((Curso curso) => curso.Nombre == "501" && curso.Jornada == TiposJornada.Mañana);

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