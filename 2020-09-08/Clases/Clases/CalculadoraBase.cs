using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public abstract class CalculadoraBase
    {
        private int Indice { get; set; }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public abstract int Dividir(int numero1, int numero2);

    }
    
}
