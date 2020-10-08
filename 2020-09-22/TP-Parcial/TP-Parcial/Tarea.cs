using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class Tarea
    {
        public string Id { get; set; }
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recurso responsable { get; set; }
        public string estado { get; set; }

        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }


        public Tarea(){ }
        public Tarea(string titulo, DateTime vencimiento, int estimacion, Recurso responsable, string estado)
        {
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsable = responsable;
            this.estado = estado;
        }
    }
}