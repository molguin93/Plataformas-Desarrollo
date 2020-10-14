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
        public string Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int RecursoId { get; set; }
        public Recurso Responsable { get; set; }
        public string Estado { get; set; }

        public Tarea() { }
        public Tarea(int id, string titulo, string vencimiento, int estimacion, int recId, string estado)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.RecursoId = recId;
            this.Estado = estado;
        }
    }
}
