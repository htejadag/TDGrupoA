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


            //PruebaLog objPruebaLog = new PruebaLog();
            //objPruebaLog.DividirEntreCero(10, 0);

            //Convertir();
            //Ingresar();

            Pregunta5();
        }

        public static void Convertir()
        {

            try
            {
                int num = 0;
                Console.WriteLine("Ingrese un numero nuevamente : ");
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
                Int32 edad = 0;
                String dato = "40000";
                //Console.WriteLine("Ingrese su edad: ");
                //string dato = Console.ReadLine(); 
                edad = Int16.Parse(dato); 
                Console.WriteLine("Tienes " + edad + " años"); 
            }
            catch (ArgumentNullException ex)
            {
                Log.Error("ArgumentNullException : " + ex.Message);
            }
            catch (FormatException ex)
            {
                Log.Error("FormatException : " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Log.Error("OverflowException : " + ex.Message);
            }
            //catch (Exception ex) {
            //    Log.Error("Exception : " + ex.Message);
            //}

        }

        public static void Pregunta1()
        {
            try
            {
                Int32 a;
                String b = "40000";
                a = Int32.Parse(b);
                Console.WriteLine("El número es " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Pregunta2()
        {
            try
            {
                //int a;
                //String b;
                //a = int.Parse(b);
                //Console.WriteLine("El número es " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Pregunta3()
        {
            try
            {
                int a;
                String b = "one";
                a = int.Parse(b);
                Console.WriteLine("El número es " + a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Pregunta4()
        {
            int a = 5, b = 0, c;
            c = a / b;
            Console.WriteLine("El resultado es " + c);
        }

        public static void Pregunta5()
        {
            string a = "5", b = "0", c = a + b;
            Console.WriteLine("El resultado es " + c);
        }
    }
}
