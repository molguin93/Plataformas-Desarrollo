using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Parcial
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>() 
                .ToTable("Usuario") // Directamente creo la tabla sin usar DataNotations. Esto se llama Fluent API
                .Property(p => p.Clave);

            modelBuilder.Entity<Tarea>()
                .ToTable("Tarea");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
