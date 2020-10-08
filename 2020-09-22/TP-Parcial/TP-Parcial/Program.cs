using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TP_Parcial
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Ejercicio1", new DateTime(2020, 5, 23), 10, new Recurso(), "Realizada"));
            tareas.Add(new Tarea("Ejercicio2", new DateTime(2020, 9, 12), 12, new Recurso(), "Realizada"));
            tareas.Add(new Tarea("Ejercicio3", new DateTime(2020, 7, 29), 12, new Recurso(), "Realizada"));
            tareas.Add(new Tarea("Ejercicio4", new DateTime(2020, 4, 06), 11, new Recurso(), "Pendiente"));

            foreach (Tarea i in tareas)
            {
                Console.Write("{0}\t", i.ToString());
            }



            Consultar();

        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");
            }

        }
        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                UsuarioPK = 1,
                Nombre = "Mauro",
                Clave = "1234"
            });

            ctx.SaveChanges();
        }

        static void ActualizarV2()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
            Usuario.Nombre = "Facu";
            ctx.SaveChanges();
        }

        static void ActualizarV1()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.UsuarioPK == 1).ToList();
            lista[0].Nombre = "Facu";
            ctx.SaveChanges();
        }

        static void Eliminar()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }  

    }
}
