using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresá tu nota del 1 al 10");

            int num = 1;
            string mensaje;
            string valor = Console.ReadLine();
            num = int.Parse(valor);

            if (num >= 1 && num < 4)
            {
                mensaje = "Recursas la materia";
            }
            else if (num == 4 || num == 5 )
            {
                mensaje = "Aprobaste la cursada, vas a final";
            }
            else if (num == 6)
            {
                mensaje = "Aprobaste la cursada, podes recuperar para promocionar";
            }
            else if (num >= 7 && num < 11)
            {
                mensaje = "Promocionaste la materia";
            }
            else
            {
                mensaje = "ingresá un número válido";
            }

            Console.WriteLine(mensaje);

        }
    }
}
