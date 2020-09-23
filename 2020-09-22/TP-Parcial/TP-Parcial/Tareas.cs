using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class Tareas
    {
        public string titulo { get; set; }
        public string vencimiento { get; set; }
        public string estimacion { get; set; }
        public Recursos responsable { get; set; }
        public string estado { get; set; }

        public Tareas(string v1, string v2, string v3, Recursos recursos, string v4)
        {
        }
    }
}
