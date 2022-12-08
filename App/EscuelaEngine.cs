using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa1.Entidades;

namespace App
{
    public class EscuelaEngine
    {
        public Escuela Escuela  { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá", pais: "Colombia");
            
            CargarCursos();
            CargarAsignaturas();
            // CargarEvaluaciones();
            

            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos.AddRange(GenerarAlumnosAlAzar(10));  //a cada curso adicionarle muchos alumnos             
            }
        }

        // private void CargarEvaluaciones()
        // {
        //     throw new NotImplementedException();
        // }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura { Nombre="Matematicas"},
                    new Asignatura { Nombre="Educación Fisíca"},
                    new Asignatura { Nombre="Castellano"},
                    new Asignatura { Nombre="Ciencias Naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            //Generar alumnos 
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            //creacion de convinaciones de arreglos profducto cartesiano
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{ Nombre=$"{n1} {n2} {a1}"};
            // Ordenar
            return listaAlumnos.OrderBy((alumno)=> alumno.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde }
            };
            Random rnd  = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);  //minimo 5 estudiantes maximo 20
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}