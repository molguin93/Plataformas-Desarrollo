using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class Detalles
    {
        public DateTime fecha { get; set; }
        public int tiempo { get; set; }
        public Recursos recurso { get; set; }
        public Tareas tarea { get; set; }
    }
}
