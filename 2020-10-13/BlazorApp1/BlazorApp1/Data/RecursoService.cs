using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        // Metodos de Recursos (Resource)

        public List<Recurso> ListResource()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Recursos.ToList();
            return lista;
        }

        static void SelectResource(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                Console.WriteLine($"Nombre: {recurso.Nombre} ({recurso.Id}) Usuario: {recurso.UsuarioId}");
            }
        }

        static void CreateResource(string nombre, int usuario)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Recurso>().Add(new Recurso
            {
                Nombre = nombre,
                UsuarioId = usuario
            });

            ctx.SaveChanges();
        }

        static void UpdateResource(int id, string name, int user = -1)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).FirstOrDefault();

            if (recurso is null)
            {
                Console.WriteLine("El recurso no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(name))
                {
                    recurso.Nombre = name;
                }
                if (user > 0)
                {
                    recurso.UsuarioId = user;
                }
            }
            ctx.SaveChanges();
        }

        static void DeleteResource(int id)
        {
            var ctx = new TareasDbContext();
            var recurso = ctx.Recursos.Where(i => i.Id == id).Single();
            ctx.Recursos.Remove(recurso);
            ctx.SaveChanges();
        }
    }
}
