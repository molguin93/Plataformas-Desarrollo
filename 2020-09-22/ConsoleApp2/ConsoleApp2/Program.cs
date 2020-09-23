using System;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehiculo miauto = new Auto();
            Auto otroauto = new Auto();
            Vehiculo camion = new Camion();
            try
            {
                miauto.Marca = "Honda";
                miauto.Modelo = "Civic";
                ((Auto)camion).Puertas = 10;
                miauto.Motor = new CuatroCilindros();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(miauto.Marca);
            }

            Console.ReadLine();
            if(camion is Auto)
            {
                
            }
        }
    }
}
