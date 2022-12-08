//using System;
//import 
//include

using System;

namespace ProyectoConsolaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Convertir();
            //Ingresar();
        }

        public static void Convertir()
        {

            try
            {
                int num = 0;
                Console.WriteLine("Ingrese un numero : ");
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
                Console.WriteLine(ex.Message);
                // Almacenarse en un log de errores
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
