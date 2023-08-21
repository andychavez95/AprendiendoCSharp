using System.IO;

namespace AdivinaNumero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            
            // Generación del número aleatorio
            int numAleatorio = rnd.Next(0, 100); 
            
            // Número de usuario.
            int usrNum;
            
            // Distancia.
            int distancia;

            bool encontrado = false;

            do
            {
                // Input usuario.
                Console.WriteLine("Ingrese su número");
                usrNum = Int32.Parse(Console.ReadLine());

                // Distancia entre num aleatorio y num de usuario.
                distancia = Math.Abs(numAleatorio - usrNum);

                if(numAleatorio == usrNum)
                {
                    Console.WriteLine("Felicidades. Diste en el clavo.");
                    encontrado = true;
                }
                else if (distancia <= 1)
                {
                    Console.WriteLine("Estas quemando.");
                }
                else if (distancia <= 5)
                {
                    Console.WriteLine("Caliente.");
                }
                else if (distancia <= 10)
                {
                    Console.WriteLine("Tibio.");
                }
                else
                {
                    Console.WriteLine("Frio.");
                }
            } while (!encontrado);
        }
    }
}

