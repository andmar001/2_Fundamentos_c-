using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa1.Entidades;

namespace Etapa1.assets.arreglos
{
    public class arregloss_
    {
        private static void TiposInstancias()
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

            Console.WriteLine("Arreglos linea por linea");
            Console.WriteLine("===============");
            Console.WriteLine(arregloCurso[0].Nombre + ", " + arregloCurso[0].UniqueId);
            Console.WriteLine($"{arregloCurso[1].Nombre}, {arregloCurso[1].UniqueId}");
            Console.WriteLine(arregloCurso[2]);

            Console.WriteLine("Colecciones");

            Console.WriteLine("======Por for=========");
            Curso.ImprimirFor(arregloCurso);
            Console.WriteLine("===============");
            Console.WriteLine("======Por foreach=========");
            Curso.ImprimirForEach(arregloCurso);
            Console.WriteLine("===============");
            Console.WriteLine("======Por while=========");
            // Curso.ImprimirWhile(arregloCurso);
            Console.WriteLine("===============");
            Console.WriteLine("======Por do while=========");
            // Curso.ImprimirDoWhile(arregloCurso);

            Console.WriteLine("===============");
            Console.WriteLine("===============");
            Console.WriteLine("Formato correcto de impresion");

            Curso[] misCursos =
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Noche },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Tarde }
            };

            escuela.Cursos = misCursos;

            foreach (var item in misCursos)
            {
                Console.WriteLine($"Nombre escuela: {item.Nombre}, Id: {item.UniqueId}");
            }

            Console.WriteLine("===============");
            Console.WriteLine("===============");
            escuela.Cursos = new Curso[]
            {
                new Curso() { Nombre = "python", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "java", Jornada = TiposJornada.Noche },
                new Curso() { Nombre = "c", Jornada = TiposJornada.Tarde }
            };
            foreach (var item in misCursos)
            {
                Console.WriteLine($"Nombre escuela: {item.Nombre}, Id: {item.UniqueId}");
            }

            Escuela escuela_dos = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");
            escuela_dos = null;

            Console.WriteLine("===============");
            Console.WriteLine("==============");

        }
    }
}