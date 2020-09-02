using System;

namespace Ej_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un número de 1 a 10");

            Random random = new Random();
            int nGanador = random.Next(10);

            int cont = 0;
            int nElegido = 0;

            while (nGanador != nElegido && cont < 3)
            {
                IngreseNumero("Ingrese otro número de 1 a 10", ref nElegido);
                cont++;
            }

            string mensaje;

            if (nGanador != nElegido)
            {
                mensaje = Perdiste(nGanador);
                // signo $ al principio, antes de las comillas, me permite poner variables entre llaves sin cerrar comillas.
            }
            else
            {
                mensaje = Ganaste();
            }

            Console.WriteLine(mensaje);
        }

        // si quisiera puedo crear estos metodos y luego llamarlos en el IF.

        static void IngreseNumero(string mensaje, ref int numero)
        {
            Console.WriteLine(mensaje);
            string valor = Console.ReadLine();
            numero = int.Parse(valor);
        }

        static String Ganaste()
        {
            return "Acertaste!!";
        }

        static String Perdiste(int valor)
        {
            return "Perdiste!! El número secreto es: " + valor;
        }
    }
}
