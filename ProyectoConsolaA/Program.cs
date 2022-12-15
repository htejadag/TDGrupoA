//using System;
//import 
//include

using System;
using Serilog;

namespace ProyectoConsolaA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración del logger
            Log.Logger = new LoggerConfiguration()
                 .WriteTo.File("log.txt")
                 .CreateLogger();


            PruebaLog objPruebaLog = new PruebaLog();
            objPruebaLog.DividirEntreCero(10, 0);

            //Convertir();
            //Ingresar();
        }

        public static void Convertir()
        {

            try
            {
                int num = 0;
                Console.WriteLine("Ingrese una letra : ");
                string dato = Console.ReadLine();
                
                bool resultado = int.TryParse(dato, out num);
                
                Console.WriteLine("Se pudo convertir : " + resultado);
                Console.WriteLine("El numero es : "+ num);
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void Ingresar() {           
            
            try
            {
                Int16 edad = 0;
                Console.WriteLine("Ingrese su edad: ");
                string dato = Console.ReadLine(); 
                edad = Int16.Parse(dato); 
                Console.WriteLine("Tienes " + edad + " años"); 
            }
            catch (ArgumentNullException ex)
            {
                // Log errores
                Console.WriteLine(ex.Message);
                // Almacenarse en un log de errores
            }
            catch (FormatException ex)
            {
                // Log errores
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                // Log errores
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {
                // Log errores
                Console.WriteLine(ex.Message);
            }

        }
    }
}
