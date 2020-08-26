using System;

namespace Ejercicio_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de 1 a 10");

            int nGanador = 5;
            int nElegido;

            string val = Console.ReadLine();
            nElegido = int.Parse(val);

            while (nGanador!=nElegido)
            {
                Console.WriteLine("Ingrese otro número de 1 a 10");
                nElegido = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acertaste!!");
        }
    }
}
