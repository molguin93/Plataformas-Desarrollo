using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Motor Motor { get; set; }

        protected abstract void Detener();

        public void Arrancar()
        {
            try
            {
                this.Prueba(0);
                Console.WriteLine("El vehiculo arranco");
            }
            catch
            {

            } 
            
        }
    }
}
