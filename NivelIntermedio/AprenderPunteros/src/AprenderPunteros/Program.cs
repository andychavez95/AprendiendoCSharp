namespace AprenderPunteros
{
    public class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int valor = 5;
                
                // Creo un apuntador.
                int* p;

                // Lo igualo a la dirección de memoria de valor.
                p = &valor;
                
                // Tomo el valor de la dirección de memoria.
                Console.WriteLine("" + *p);

                // Cambiamos el valor de la que está almacenado en la direccion
                // de memoria.
                *p = 10;
                Console.WriteLine("" + *p);
                Console.WriteLine("" + valor);
            }
        }
    }
}
