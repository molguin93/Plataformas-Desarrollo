using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface IAcuatico
    {
        int velocidad { get; set; }

        void Navegar(string destino);
    }
}
