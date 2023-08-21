namespace ListaEnlazadaDoble 
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaDoble led = new ListaEnlazadaDoble();

            led.agregar(10);
            led.agregar(27);
            led.agregar(28);
            led.agregar(7);
            led.agregar(1);

            //Console.WriteLine(miLista.cantTotal());
            //miLista.imprimirLista();
            
            led.buscElem(1);
        }
    }
}
