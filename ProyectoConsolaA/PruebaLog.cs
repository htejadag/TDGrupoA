using System;
using System.Collections.Generic;
using System.Text;
using Serilog;

namespace ProyectoConsolaA
{
    public class PruebaLog
    {

        // Atributos 


        // Métodos

        public void IngresaNombre()
        {

            Console.WriteLine("Ingrese su nombre :");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola :" + nombre);
        }

        public void DividirEntreCero(int a, int b)
        {
            try
            {
                //Log.Information("");
                //Log.Warning("");
                //Log.Error("");
                Log.Information("El valor de a es : " + a);

                Log.Information("El valor de b es : " + b);

                int c;
                //Console.WriteLine("Ingrese un número:");
                //string aa = Console.ReadLine();
                //a = int.Parse(aa);

                //Console.WriteLine("Ingrese otro número:");
                //string bb = Console.ReadLine();
                //b = int.Parse(bb);

                c = a / b;

                Console.WriteLine("El resultado es :" + c);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                //Console.WriteLine(ex.Message);
            }
        }

    }
}
