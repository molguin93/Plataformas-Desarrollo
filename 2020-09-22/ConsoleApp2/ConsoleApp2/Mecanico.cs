using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Mecanico
    {
        public void Arreglar(IRepuesto repuesto)
        {
            Console.WriteLine(repuesto.Precio);
        }
    }
}
