﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using ClassLibrary1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public TareaController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> Get()
        {
            return await _context.Tareas.Include(i => i.Responsable).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTask(int id)
        {
            return await _context.Tareas.Where(i => i.Id == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Tarea>> Post(Tarea valor)
        {
            var local = _context.Tareas.Local.FirstOrDefault(i => i.Id.Equals(valor.Id));

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            if (valor.Id == 0)
            {
                await _context.Tareas.AddAsync(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = _context.Tareas.Where(i => i.Id == id).Single();

            _context.Tareas.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
