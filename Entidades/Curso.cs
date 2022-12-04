using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Curso() => UniqueId = Guid.NewGuid().ToString();

        //recorrido por for
        public static void ImprimirFor(Curso[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Nombre escuela: {arreglo[i].Nombre}, Id: {arreglo[i].UniqueId}");
            }
        }
        //recorrido por foreach
        public static void ImprimirForEach(Curso[] arreglo)
        {
            foreach (var curso in arreglo)
            {
                Console.WriteLine($"Nombre escuela: {curso.Nombre}, Id: {curso.UniqueId}");
            }
        }
        //recorrido por while
        public static void ImprimirWhile(Curso[] arreglo)
        {
            int i = 0;
            while (i <= arreglo.Length)
            {
                Console.WriteLine($"Nombre curso: {arreglo[i].Nombre}, Id: {arreglo[i].UniqueId}");
                i++;
            }
        }
        //recorrido por do while
        public static void ImprimirDoWhile(Curso[] arreglo)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Nombre curso: {arreglo[i].Nombre}, Id: {arreglo[i].UniqueId}");
                i++;
            } while (i < arreglo.Length);
        }

        public static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("===============");
            Console.WriteLine("Cursos de la escuela");
            Console.WriteLine("===============");

            // Validar que la escuela no sea nulla
            if (escuela != null && escuela.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre curso: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}