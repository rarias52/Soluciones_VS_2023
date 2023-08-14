using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTareas
{
    internal class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
            FechaCreacion = DateTime.Now;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
