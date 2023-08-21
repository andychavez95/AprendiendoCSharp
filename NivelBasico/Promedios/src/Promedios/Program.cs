using System;
using System.IO;

namespace Promedios
{
    public class Promedios
    {
        public static void Main(string[] args)
        {
            int cantCalif;

            Console.WriteLine("Ingrese la cantidad de calificaciones:");
            cantCalif = Math.Abs(Int32.Parse(Console.ReadLine()));
            
            // Iterador
            int i = 0;

            // Acumulado de notas
            int notas = 0;

            // Nota ingresada.
            int nota;

            do
            {
               Console.WriteLine("Ingrese la " + (i+1) + " nota:");
               nota = Int32.Parse(Console.ReadLine());
               notas = notas + nota;
               i++;
            } while (cantCalif != i);

            Console.WriteLine("El promedio es: " + (notas / i));
        }
    }
}

