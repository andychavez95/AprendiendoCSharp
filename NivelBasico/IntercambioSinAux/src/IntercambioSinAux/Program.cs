namespace IntercambioSinAux
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            // Usando sumas y restas.
            a = 5;
            b = 6;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Nuevo valor de a: " + a);
            Console.WriteLine("Nuevo valor de b: " + b);

            // Usando multiplicaciones y divisiones.
            a = 5;
            b = 6;

            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Nuevo valor de a: " + a);
            Console.WriteLine("Nuevo valor de b: " + b);
        }
    }
}

