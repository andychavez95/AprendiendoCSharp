namespace FibonacciIterador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length;

            do
            {
                Console.WriteLine("Ingrese la cantidad de números de la secuencia de fibonacci a imprimir.");

                length = Int32.Parse(Console.ReadLine());
                
            } while (length <= 0);
            
            SecuenciaFibonacci secFib;

            if (length > 2)
            {
                secFib = new SecuenciaFibonacci(length);
                secFib.agregarDos();
                completSecueFib(length, secFib.getSecueFib());
            }
            else if(length == 2)
            {
                secFib = new SecuenciaFibonacci(length);
                secFib.agregarDos();
            }
            else
            {
                secFib = new SecuenciaFibonacci(length);
                secFib.agregarUno();
            }

            printSecueFib(secFib.getSecueFib());
        }

        private static void completSecueFib(int n, int[] secueFib)
        {
            int length = secueFib.Length - 2;

            for (int i = 1; i <= length; i++)
            {
                secueFib[i+1] = secueFib[i] + secueFib[i-1];
            }
        }

        private static void printSecueFib(int[] secueFib)
        {
            Console.Clear();
            Console.WriteLine("=============");
            foreach(int n in secueFib)
            {
                Console.WriteLine("" + n);
            }
            Console.WriteLine("=============");
        }
    }
}

