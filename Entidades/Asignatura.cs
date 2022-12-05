using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
    }
}