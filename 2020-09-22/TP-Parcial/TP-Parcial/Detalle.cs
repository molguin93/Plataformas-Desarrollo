using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class Detalle
    {
        public DateTime fecha { get; set; }
        public int tiempo { get; set; }
        public Recurso recurso { get; set; }
        public Tarea tarea { get; set; }
    }
}
