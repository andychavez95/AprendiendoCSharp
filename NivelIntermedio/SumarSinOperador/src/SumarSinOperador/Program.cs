namespace SumarSinOperador
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;
            Console.WriteLine("La suma (M1) es: " + sumaM1(a, b));
            Console.WriteLine("La suma (M1) es: " + sumaM2(a, b));
        }

        private static int sumaM1(int a, int b)
        {
            int suma = a;
            
            while (b != 0)
            {
                suma++;
                b--;
            }

            return suma;
        }

        private static int sumaM2(int a, int b)
        {
            int suma = 0;

            for (int i = 0; i < a; i++)
            {
               suma++; 
            }

            for (int i = 0; i < b; i++)
            {
               suma++; 
            }

            return suma;
        }
    }
}
