using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Clases
{
    public class Calculadora : CalculadoraBase// Si no dice nada la clase es private
    {
        //private int numero1;
        //public int Numero1
        //{
        //    get
        //    {
        //        return numero1;
        //    }
        //    set
        //    {
        //        numero1 = value;
        //    }
        //}

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }  // se puede colocar antes de cada uno el private si lo deseo.

        public Calculadora()
        {

        }

        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        /// <summary>
        /// Este metodo es de prueba
        /// </summary>
        /// <param name="valor"> Este es el parametro </param>
        /// <returns></returns>

        public int Metodo(int valor)
        {
            return 0; 
        }

        public int Metodo(String valor)
        {
            return 0;
        }

        public int Metodo(int valor, int valor2)
        {
            return 0;
        }

        public int Metodo()
        {
            if (Numero1 == Numero2)
            {
                return 0;
            }
            return 1;
        }

        public int Sumar(int numero1, int numero2)
        {
            return numero1+numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
