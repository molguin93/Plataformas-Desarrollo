using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class TareaService
    {

        // Metodos de Tareas (Task)

        //private TareasDbContext ctx;

        //public TareaService(TareasDbContext _context)
        //{
        //    ctx = _context;
        //}

        public async Task<List<Tarea>> ListTask()
        {
            //return await ctx.Tareas.Include(i => i.Responsable).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> SelectTask(int id)
        {
            //return await ctx.Tareas.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetTarea(id);
        }

        public async Task<Tarea> SaveTask(Tarea value)
        {
            //if (value.Id == 0)
            //{
            //    await ctx.Tareas.AddAsync(value);
            //}
            //else
            //{
            //    ctx.Tareas.Update(value);
            //}
            //await ctx.SaveChangesAsync();
            //return value;
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarTarea(value);
        }

        public async Task<bool> DeleteTask(int id)
        {
            //Tarea task = await ctx.Tareas.Where(i => i.Id == id).SingleAsync();

            //ctx.Tareas.Remove(task);

            //await ctx.SaveChangesAsync();
            //return true;
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarTarea(id);
            return true;
        }

    }
}
