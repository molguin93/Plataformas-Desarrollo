using System;
using ClassLibrary1;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            
            Console.WriteLine(calculadora.Sumar(1, 4));
            Console.WriteLine(calculadora.Restar(2, 4));
            Console.WriteLine(calculadora.Multiplicar(3, 4));
            Console.WriteLine(calculadora.Dividir(10, 5));

            CalculadoraCientifica cientifica = new CalculadoraCientifica();
            Console.WriteLine(cientifica.Sumar(1, 4));
            Console.WriteLine(cientifica.Potencia(1, 4));

            Ayuda.Sumar(1, 2);

            //Calculadora calculadora1 = new Calculadora(5, 8);
            //Calculadora calculadora2;

            //calculadora2 = new Calculadora();

            //calculadora.Numero1 = 10;
            //Console.WriteLine(calculadora.Numero1);

            //calculadora.Numero2 = 23;
            //Console.WriteLine(calculadora.Numero2);

            //calculadora.Metodo(1);
            //calculadora.Metodo(1,2);
            //calculadora.Metodo("");

            //calculadora = null;  // hace que el garbash collector libere el espacio de memoria de la variable
        }
    }
}
