using System;
using System.IO;

namespace ConversionTemperatura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte opcion;
            float temperatura;
            float resultado;

            Console.WriteLine("************************************");
            Console.WriteLine("Elija una de las opciones a convertir: ");
            Console.WriteLine("1.- Convertir de Farenheit a Celsius");
            Console.WriteLine("2.- Convertir de Celsius a Farenheit");
            Console.WriteLine("************************************");
            
            opcion = Byte.Parse(Console.ReadLine());

            while (opcion != 1 && opcion != 2)
            {
                Console.WriteLine("OPCIÓN INVALIDA");
                Console.WriteLine("************************************");
                Console.WriteLine("Elija una de las opciones a convertir: ");
                Console.WriteLine("1.- Convertir de Farenheit a Celsius");
                Console.WriteLine("2.- Convertir de Celsius a Farenheit");
                Console.WriteLine("************************************");
                
                opcion = Byte.Parse(Console.ReadLine());
            }

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese la temperatura en Farenheit:");
                temperatura = float.Parse(Console.ReadLine());
                resultado = farenheitToCelsius(temperatura);                
                printConversion(opcion, temperatura, resultado);
            }
            else
            {
                Console.WriteLine("Ingrese la temperatura en Celsius:");
                temperatura = float.Parse(Console.ReadLine());
                resultado = celsiusToFarenheit(temperatura);        
                printConversion(opcion, temperatura, resultado);
            }
        }

        private static void printConversion(byte opc, float temp, float resul)
        {
            // Limpia la pantalla.
            Console.Clear();

            if (opc == 1)
            {
                Console.WriteLine(temp + " grados Farenheit a Celsius es " + resul);
            }
            else
            {
                Console.WriteLine(temp + " grados Celsius a Farenheit es " + resul);
            }
        }

        private static float farenheitToCelsius(float f)
        {
            return (f - 32) * 0.5556f;
        }

        private static float celsiusToFarenheit(float c)
        {
            return (c * 1.8f) + 32;
        }
    }
}
