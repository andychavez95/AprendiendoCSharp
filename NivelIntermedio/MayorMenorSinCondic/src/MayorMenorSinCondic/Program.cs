/*
 * Hallar el menor de dos números enteros positivos sin utilizar condicionales
 * ni operadores ternarios. Suponer que los números no son iguales
 */
using System.IO;

namespace MayorMenorSinCondic
{
    public class Program
    {
        static void Main(string[] args)
        {
           int elMenor = 0;

           elMenor = menorM1(4, 3);
           Console.WriteLine("Método 1. Menor: " + elMenor);
            
           elMenor = menorM2(4, 3); 
           Console.WriteLine("Método 2. Menor: " + elMenor);

           elMenor = menorM3(4, 3);
           Console.WriteLine("Método 3. Menor: " + elMenor);
        }
        
        private static int menorM2(int a, int b)
        {
            int[] arr = new int[2] {a, b};
            return arr[Convert.ToInt32(a > b)];
        }

        private static int menorM3(int a, int b)
        {
            return Convert.ToInt32(a > b) * b + Convert.ToInt32(b > a) * a;
        }

        private static int menorM1(int a, int b)
        {
            int minimo = 0;

            while (a != 0 && b != 0)
            {
                --a;
                --b;
                ++minimo;
            }

            return minimo;
        }

        // private static int menorM4(int a, int b)
        // {
        //     int minimo = a;
        //     (minimo > b) && (minimo = b);
        //     return minimo;
        // }
    }
}

