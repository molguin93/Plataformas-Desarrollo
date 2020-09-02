using System;

namespace ej_Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            String mensaje;

            IngreseYear("Ingresá el año en qué naciste", out year);

            if (Bisiesto(year) == true)
            {
                mensaje = "Es Bisiesto";
            } else {
                mensaje = "No es Bisiesto";
            }

            Console.WriteLine(mensaje);

        }

        static void IngreseYear(string mensaje, out int year)
        {
            Console.WriteLine(mensaje);
            string valor = Console.ReadLine();
            year = int.Parse(valor);
        }

        static bool Bisiesto(int year)
        {
            if(year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
