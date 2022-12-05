using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();   //asignacion de ui de manera directa
        string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string  Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }

        public Curso[] Cursos { get; set; }

        public List<Curso> ListaCursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

        public Escuela (string nombre,  
                        int año,
                        TiposEscuela tipo,
                        string pais = "",
                        string ciudad = "")
                        {
                            (Nombre, AñoCreacion) = (nombre, año);
                            this.Pais = pais;
                            this.Ciudad = ciudad;
                        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela}, {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad} \n";
        }

        public void timbrar()
        {
            Console.Beep(100, 2000); // 10000 Hz, 3000 ms
        }
    }


}