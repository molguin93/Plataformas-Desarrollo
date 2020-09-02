using System;

namespace Ej_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de 1 a 10");

            Random random = new Random();
            int nGanador = random.Next(10);

            int cont = 1;
            int nElegido;

            string val = Console.ReadLine();
            nElegido = int.Parse(val);


            while (nGanador != nElegido && cont < 3)
            {
                Console.WriteLine("Ingrese otro número de 1 a 10");
                nElegido = int.Parse(Console.ReadLine());
                cont++;
            }

            if (nGanador != nElegido)
            {
                Console.WriteLine($"Perdiste!! El número secreto es: {nGanador}");
                // signo $ al principio, antes de las comillas, me permite poner variables entre llaves sin cerrar comillas.
            }
            else
            {
                Console.WriteLine("Acertaste!!");
            }
        }

    }
}
