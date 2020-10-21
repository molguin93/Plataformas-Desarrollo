using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        // Metodos de Usuarios (User)
        public List<Usuario> ListUser()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();
            return lista;
        }

        static void SelectUser(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("El usuario no existe");
            }
            else
            {
                Console.WriteLine($"Nombre: {usuario.Nombre} ({usuario.UsuarioPK})");
            }
        }

        static void CreateUser(string name, string pass)
        {
            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                Nombre = name,
                Clave = pass
            });

            ctx.SaveChanges();
        }

        static void UpdateUser(int id, string name, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("El usuario no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(name))
                {
                    usuario.Nombre = name;
                }
                if (!string.IsNullOrEmpty(pass))
                {
                    usuario.Clave = pass;
                }
            }
            ctx.SaveChanges();
        }

        static void ResetPasswordUser(int id, string pass = null)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).FirstOrDefault();

            if (usuario is null)
            {
                Console.WriteLine("El usuario no existe");
            }
            else
            {
                if (!string.IsNullOrEmpty(pass))
                {
                    usuario.Clave = pass;
                }
            }
            ctx.SaveChanges();
        }

        static void DeleteUser(int id)
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }
    }
}
