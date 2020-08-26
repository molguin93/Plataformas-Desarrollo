using System;

namespace Ej._For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese 10 numeros, la suma se interrumpirá si supera el total de 50");

            int num = 1;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                string val = Console.ReadLine();
                num = int.Parse(val);

                sum += num;

                if (sum > 50)
                {
                    break;
                }
            }

            Console.Write("La suma es: " + sum);
        }
    }
}
