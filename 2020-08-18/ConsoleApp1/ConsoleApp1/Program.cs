using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            int dado = 1;
            string mensaje;
            string valor = Console.ReadLine(); // con F9 sobre la línea seteo un breakpoint.
            dado = int.Parse(valor);
           
            if (dado == 1)
            {
                mensaje = "te ganaste un auto";
            }
            else if (dado == 2 || dado == 5)
            {
                mensaje = "te ganaste una moto";
            }
            else if (dado > 2 && dado < 5)
            {
                mensaje = "te ganaste un perro";
            }
            else
            {
                mensaje = "segui participando";
            }

            // mensaje = dado == 1 ? "te ganaste un auto" : dado == 2 ? "te ganaste una moto" : "segui participando";

            Console.Write("Tu dado fue " + valor + " y te ganaste " + mensaje);
            Console.Write(string.Format("Tu dado fue {0} y te ganaste {1}", dado, mensaje));
            Console.Write($"Tu dado fue {dado} y te ganaste {mensaje}");


            for (int posicion = 10; posicion < 20; posicion++)
            {
                if (posicion == 15)
                {
                    break;
                }
            }


            Console.WriteLine("Por favor ingrese 10 numeros");

            int num = 1;

            for (int sum = 10; sum <= 50; sum++)
            {
                string val = Console.ReadLine();
                num = int.Parse(val);

                sum += num;
                
                if (sum == 15)
                {
                    break;
                }
            }

            Console.Write("La suma es: " + sum );


            // Tipos de Datos

            short valor0; // es igual que poner int16
            int valor; // es igual que poner int32
            long valor3; // es igual que poner int64
            float valor4; // es punto flotante de 32 bits (se guarda en base 2, es mas rápido)
            
            double valor5; // es punto flotante de 64 bits
            decimal valor6; // es punto flotante de 64 bits con mayor presición pero es mucho mas lento (20 veces) (se guarda en base 10)
            
            char valor2; 
            string valor1; // es igual que String

            valor = int.Parse(valor1); // convierto la variable valor1 que es string en int

            Console.WriteLine(mensaje);
        }
    }
}
