using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        // Metodos de Detalle (Detail)

        public List<Detalle> ListDetail()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Detalles.ToList();
            return lista;
        }

        static void SelectDetail(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                Console.WriteLine($"Fecha: {detalle.Fecha} ({detalle.Id}) Tiempo: {detalle.Tiempo} " +
                                    $"Recurso: {detalle.RecursoId} Tarea: {detalle.TareaId}");
            }
        }

        static void CreateDetail(int time, int recurso, int tarea)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Detalle>().Add(new Detalle
            {
                Fecha = DateTime.Now,
                Tiempo = time,
                RecursoId = recurso,
                TareaId = tarea
            });

            ctx.SaveChanges();
        }

        static void UpdateDetailFull(int id, int time, int recId, int taskId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (time > 0)
                {
                    detalle.Tiempo = time;
                }
                if (recId > 0)
                {
                    detalle.RecursoId = recId;
                }
                if (taskId > 0)
                {
                    detalle.TareaId = taskId;
                }
            }
            ctx.SaveChanges();
        }

        static void UpdateDetailTime(int id, int time)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (time > 0)
                {
                    detalle.Tiempo = time;
                }
            }
            ctx.SaveChanges();
        }

        static void UpdateDetailResource(int id, int recId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (recId > 0)
                {
                    detalle.RecursoId = recId;
                }
            }
            ctx.SaveChanges();
        }

        static void UpdateDetailTask(int id, int taskId)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).FirstOrDefault();

            if (detalle is null)
            {
                Console.WriteLine("El detalle no existe");
            }
            else
            {
                detalle.Fecha = DateTime.Now;

                if (taskId > 0)
                {
                    detalle.TareaId = taskId;
                }
            }
            ctx.SaveChanges();
        }

        static void DeleteDetail(int id)
        {
            var ctx = new TareasDbContext();
            var detalle = ctx.Detalles.Where(i => i.Id == id).Single();
            ctx.Detalles.Remove(detalle);
            ctx.SaveChanges();
        }
    }
}
