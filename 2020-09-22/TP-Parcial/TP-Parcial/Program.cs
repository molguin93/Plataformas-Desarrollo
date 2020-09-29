using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TP_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tareas> tareas = new List<Tareas>();
            tareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 5, 23), 10, new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio2", new DateTime(2020, 9, 12), 12, new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio3", new DateTime(2020, 7, 29), 12, new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio4", new DateTime(2020, 4, 06), 11, new Recursos(), "Pendiente"));

            foreach (Tareas i in tareas)
            {
                Console.Write("{0}\t", i.ToString());
            }
        }

    }
}
