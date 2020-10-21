using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int RecursoId { get; set; }
        public Recurso Responsable { get; set; }
        public string Estado { get; set; }

        public Tarea() { }
        public Tarea(string titulo, DateTime vencimiento, int estimacion, Recurso responsable, string estado)
        {
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.Responsable = responsable;
            this.Estado = estado;
        }
    }
}
