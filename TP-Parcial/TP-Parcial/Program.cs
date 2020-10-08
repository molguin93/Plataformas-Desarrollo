using System;
using System.Linq;


namespace TP_Parcial
{
    class Program
    {

        static void Main(string[] args)
        {
            //ListUser();
            //ListTask();
            //ListResource();
            //ListDetail();


            CreateUser("Juan", "asd123");
            CreateUser("Felipe", "qwe123");
            CreateUser("Maria", "zxc123");
            CreateUser("Prueba", "a123");
            //UpdateUser(1, "Juan Carlos");
            //ResetPasswordUser(3, "qwert123");
            //SelectUser(1);s
            //DeleteUser(4);


            CreateResource("Operador", 1);
            CreateResource("Analista", 2);
            CreateResource("Prueba", 2);
            //UpdateResource(2, "Analista IT");
            //SelectResource(1);
            //DeleteResource(3);


            CreateTask("Primer Tarea", "2020/10/22", 7, 1, "pendiente");
            CreateTask("Primer Tarea", "2020/11/22", 7, 1, "pendiente");
            CreateTask("Tercer Tarea", "2020/11/22", 7, 1, "pendiente");
            //UpdateTaskTitle(2, "Segunda Tarea");
            //UpdateTaskTime(2, "2020/11/09", 15);
            //UpdateTaskTime(2, "2020/11/09");
            //UpdateTaskResource(1, 2);
            //UpdateTaskStatus(1, "En Proceso");
            //SelectTask(2);
            //DeleteTask(3);


            CreateDetail(8, 2, 2);
            CreateDetail(12, 2, 2);
            CreateDetail(4, 2, 2);
            //UpdateDetailFull(2, 7, 1, 1);
            //UpdateDetailResource(1, 1);
            //UpdateDetailTask(1, 1);
            //UpdateDetailTime(2, 16);
            //SelectDetail(2);
            //DeleteDetail(3);

        }

        // Metodos de Usuarios (User)
        static void ListUser()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");
            }

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

        static void CreateUser(string name,  string pass)
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

        // Metodos de Tareas (Task)
        static void ListTask()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Tareas.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Titulo: {item.Titulo} ({item.Id}) Vencimiento: {item.Vencimiento} " +
                    $"Estimacion: {item.Estimacion} Responsable: {item.RecursoId} Estado: {item.Estado}");
            }
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

        static void CreateTask(string titulo, string vencimiento,int estimacion, int responsable, string estado = null)
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

        // Metodos de Recursos (Resource)

        static void ListResource()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Recursos.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.Id}) Usuario: {item.UsuarioId}");
            }
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

        // Metodos de Detalle (Detail)

        static void ListDetail()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Detalles.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Fecha: {item.Fecha} ({item.Id}) Tiempo: {item.Tiempo} " +
                                    $"Recurso: {item.RecursoId} Tarea: {item.TareaId}");
            }
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
