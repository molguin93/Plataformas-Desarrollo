using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        //public Tarea[] GetTareas()
        //{
        //    Tarea[] resultado = new Tarea[10];
        //    resultado[0] = new Tarea("Tarea 1", "2020/05/10", 12, 1, "Pendiente");
        //    resultado[1] = new Tarea("Tarea 2", "2020/02/12", 15, 2, "En Proceso");
        //    resultado[2] = new Tarea("Tarea 3", "2020/01/22", 5, 2, "Finalizada");
        //    resultado[3] = new Tarea("Tarea 4", "2020/11/13", 12, 5, "Pendiente");
        //    resultado[4] = new Tarea("Tarea 5", "2020/09/19", 7, 3, "En Proceso");
        //    resultado[5] = new Tarea("Tarea 6", "2020/10/02", 20, 1, "Pendiente");
        //    resultado[6] = new Tarea("Tarea 7", "2020/05/25", 7, 3, "En Proceso");
        //    resultado[7] = new Tarea("Tarea 8", "2020/07/30", 12, 2, "En Proceso");
        //    resultado[8] = new Tarea("Tarea 9", "2020/03/15", 20, 2, "Finalizada");
        //    resultado[9] = new Tarea("Tarea 10", "2020/07/30", 5, 4, "Finalizada");

        //    return resultado;
        //}


        // Metodos de Tareas (Task)
        public List<Tarea> ListTask()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Tareas.ToList();
            return lista;
        }

        static void SelectTask(int id)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                Console.WriteLine($"Titulo: {tarea.Titulo} ({tarea.Id}) Vencimiento: {tarea.Vencimiento} Estimacion: {tarea.Estimacion} " +
                                $"Responsable: {tarea.RecursoId} Estado {tarea.Estado}");
            }
        }

        static void CreateTask(string titulo, string vencimiento, int estimacion, int responsable, string estado = null)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Tarea>().Add(new Tarea
            {
                Titulo = titulo,
                Vencimiento = DateTime.Parse(vencimiento),
                Estimacion = estimacion,
                RecursoId = responsable,
                Estado = estado
            });

            ctx.SaveChanges();
        }

        static void UpdateTaskTitle(int id, string tit)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Titulo = tit;
            }
            ctx.SaveChanges();
        }

        static void UpdateTaskStatus(int id, string sta)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Estado = sta;
            }
            ctx.SaveChanges();
        }

        static void UpdateTaskResource(int id, int resp)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.RecursoId = resp;
            }
            ctx.SaveChanges();
        }

        static void UpdateTaskTime(int id, string venc, int est = -1)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).FirstOrDefault();

            if (tarea is null)
            {
                Console.WriteLine("La tarea no existe");
            }
            else
            {
                tarea.Vencimiento = DateTime.Parse(venc);

                if (est > 0)
                {
                    tarea.Estimacion = est;
                }
            }
            ctx.SaveChanges();
        }

        static void DeleteTask(int id)
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tareas.Where(i => i.Id == id).Single();
            ctx.Tareas.Remove(tarea);
            ctx.SaveChanges();
        }


    }
}
