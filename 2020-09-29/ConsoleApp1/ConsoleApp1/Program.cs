using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Intro();
            Console.ReadLine(); 
        }

        public static void EF()
        {
            var ctx = new AppContext();

            var lista = ctx.Actividades.ToList();
            var lista2 = ctx.Actividades.Where(i => i.Fecha < DateTime.Now).ToList();

            Actividad actividad = lista[0];
            actividad.Nombre = "nuevo nombre";

            var lista3 = ctx.Actividades.Where(i => i.Id == 15).First();
            ctx.Actividades.Remove(lista3);

            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
            ctx.Actividades.Add(new Actividad { Lugar = "online", Nombre = "Clase2" });
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase3" });

            ctx.SaveChanges(); //REaliza los cambios que hice antes, en este caso crear 3 registros nuevos
        }

        public static void Agregado(string orden)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(numeros.Average());
            Console.WriteLine(numeros.Count());
            Console.WriteLine(numeros.Sum());
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());

        }

        public static void Todo(string orden)
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms Build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon Summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms Ignite", Fecha = new DateTime(2020, 9, 25) });

            var resultado = eventos
                .Where(i => i.Fecha<DateTime.Now)
                .OrderBy(i => i.Fecha)
                .Select(i => new ActividadDto { Nombre = i.Nombre, Lugar = i.Lugar });

            var resultado2 = eventos
                .Where(i => i.Fecha < DateTime.Now);

            if (orden == "fecha")
            {
                resultado2 = resultado2.OrderBy(i => i.Fecha);
            }
            else
            {
                resultado2 = resultado2.OrderBy(i => i.Nombre);
            }
        }

        public static void Proyeccion()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms Build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon Summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms Ignite", Fecha = new DateTime(2020, 9, 25) });

            var nombres = eventos.Select(i => i.Nombre);
            var nombres2 = eventos.Select(i => new { i.Nombre, i.Lugar});
            var nombres3= eventos.Select(i => new ActividadDto{ Nombre= i.Nombre, Lugar= i.Lugar });
        }

        public static void GroupBy()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms Build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon Summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms Ignite", Fecha = new DateTime(2020, 9, 25) });

            var grupos = eventos.GroupBy(i => i.Lugar);
            var grupos2 = eventos.GroupBy(i => new { i.Lugar, i.Fecha });

            foreach (var item in grupos2)
            {
                //item.Key.Fecha;
            }
        }

        public static void Ordenar()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms Build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon Summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms Ignite", Fecha = new DateTime(2020, 9, 25) });

            var ordenado = eventos.OrderByDescending(i => i.Fecha);
            var ordenado2 = eventos.OrderBy(i => i.Nombre);
            var ordenado3 = eventos.OrderByDescending(i => i.Fecha).ThenBy(i=>i.Nombre);
        }

        public static void PruebaOfType()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("test");
            arrayList.Add("Gabriel");
            arrayList.Add(1);
            arrayList.Add(2);

            var numeros = arrayList.OfType<int>();

            List<IActividad> eventos = new List<IActividad>();
            //eventos.Add(new Actividad());


        }

        public static void Intro()
        {
            string[] nombres = { "Gabriel", "Facundo", "Francisco", "Maria Laura", "Francisco" };

            IEnumerable<string> empiezanConF = from nombre in nombres where nombre.StartsWith("F") select nombre;

            IEnumerable<string> emoiezanConM = nombres.Where(i => i.StartsWith("M"));

            IEnumerable<string> unicos = nombres.Distinct();

            foreach (var item in empiezanConF)
            {
                Console.WriteLine(item);
            }


            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms Build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon Summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms Ignite", Fecha = new DateTime(2020, 9, 25) });

            IEnumerable<string> pasados = eventos.Where(i => i.Fecha < DateTime.Now).Select(i => i.Nombre);

            //List<string> pasados = eventos.Where(i => i.Fecha < DateTime.Now).Select(i => i.Nombre).toList();

            Func<int, string, bool> validarEdad = (edad, genero) => (edad > 18 && genero == "M") || (edad > 19 && genero == "F");

            Func<int, string, bool> validarEdad2 = (edad, genero) =>
            {
                if (genero == "M")
                {
                    return edad > 18;
                }
                else
                {
                    return edad > 19;
                }
            };


            Action<int> imprimir = (valor) => Console.WriteLine(valor);

            validarEdad(20, "M");

            validarEdad2(20, "F");
        }

        public void ImprimirFull(int edad) // este metodo es igual que usar el action q hicimos arriba.
        {
            Console.WriteLine(edad);
        }

        public bool validarEdadFull(int edad)
        {
            return edad > 18;
        }

        public static void Ejercicio()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var numerosPar = numeros.Where(i => i % 2 == 0).OrderByDescending(i => i);

            foreach (var i in numerosPar)
            {
                Console.WriteLine(i);
            }
        }

    }
}
