using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Tarea[] GetTareas()
        {
            Tarea[] resultado = new Tarea[10];
            resultado[0] = new Tarea(1, "Tarea 1", "2020/05/10", 12, 1, "Pendiente");
            resultado[1] = new Tarea(2, "Tarea 2", "2020/02/12", 15, 2, "En Proceso");
            resultado[2] = new Tarea(3, "Tarea 3", "2020/01/22", 5, 2, "Finalizada");
            resultado[3] = new Tarea(4, "Tarea 4", "2020/11/13", 12, 5, "Pendiente");
            resultado[4] = new Tarea(5, "Tarea 5", "2020/09/19", 7, 3, "En Proceso");
            resultado[5] = new Tarea(6, "Tarea 6", "2020/10/02", 20, 1, "Pendiente");
            resultado[6] = new Tarea(7, "Tarea 7", "2020/05/25", 7, 3, "En Proceso");
            resultado[7] = new Tarea(8, "Tarea 8", "2020/07/30", 12, 2, "En Proceso");
            resultado[8] = new Tarea(9, "Tarea 9", "2020/03/15", 20, 2, "Finalizada");
            resultado[9] = new Tarea(10, "Tarea 10", "2020/07/30", 5, 4, "Finalizada");

            return resultado;
        }
        


    }
}
