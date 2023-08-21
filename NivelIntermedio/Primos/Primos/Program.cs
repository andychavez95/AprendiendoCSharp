using System.Collections;

namespace Primos
{
    public class Program
    {
        private static List<int> primos = new List<int>();

        public static void Main(string[] args)
        {
            primos.Add(2);
            int num = 3;
            
            do
            {
                if(esPrimo(num)) primos.Add(num); 
                num++;
            } while (primos.Count < 100);

            imprimirPrimos();
        }

        private static void imprimirPrimos()
        {
            foreach(int primo in primos)
            {
                Console.WriteLine("" + primo);
            }
        }
        
        private static bool esPrimo(int n)
        {
            foreach(int primo in primos)
            {
                if(n % primo == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
