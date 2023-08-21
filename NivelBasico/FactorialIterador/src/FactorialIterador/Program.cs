namespace FactorialIterador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uint num;
            uint resultado;

            do
            {
                Console.WriteLine("Ingrese un número mayor a 1.");
                num = uint.Parse(Console.ReadLine());
                resultado = calcularFactorial(num);
            } while (num <= 1);

            Console.WriteLine("El factorial de " + num + " es " + resultado + ".");
        }

        private static uint calcularFactorial(uint n)
        {
            uint resultado = 1;

            for (uint i = 2; i <= n; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
