﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        // Metodos de Detalle (Detail)

        //private TareasDbContext ctx;

        //public DetalleService(TareasDbContext _context)
        //{
        //    ctx = _context;
        //}

        public async Task<List<Detalle>> ListDetail()
        {
            //return await ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> SelectDetail(int id)
        {
            //return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetDetalle(id);
        }

        public async Task<Detalle> SaveDetail(Detalle value)
        {
            //if (value.Id == 0)
            //{
            //    await ctx.Detalles.AddAsync(value);
            //}
            //else
            //{
            //    ctx.Detalles.Update(value);
            //}
            //await ctx.SaveChangesAsync();
            //return value;
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarDetalle(value);
        }

        public async Task<bool> DeleteDetail(int id)
        {
            //Detalle det = await ctx.Detalles.Where(i => i.Id == id).SingleAsync();

            //ctx.Detalles.Remove(det);

            //await ctx.SaveChangesAsync();
            //return true;

            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarDetalle(id);
            return true;
        }
    }
}
