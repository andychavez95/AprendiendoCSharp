namespace ParImpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Ingrese un número entero:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero == 0);

            if (isPar(numero))
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }

        private static bool isPar(int n)
        {
            int resto = n % 2;
            return (resto == 0);
        }
    }
}

