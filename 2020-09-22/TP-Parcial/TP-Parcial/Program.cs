using System;
using System.Collections.Generic;

namespace TP_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tareas> tareas = new List<Tareas>();
            tareas.Add(new Tareas("Ejercicio1", "2020-9-22", "10", new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio2", "2020-9-23", "12", new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio3", "2020-9-24", "12", new Recursos(), "Realizada"));
            tareas.Add(new Tareas("Ejercicio4", "2020-9-25", "11", new Recursos(), "Pendiente"));
        }

    }
}
