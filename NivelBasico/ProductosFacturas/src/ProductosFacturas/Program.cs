namespace ProductosFacturas
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Producto> lstP = new List<Producto>();
            ingresarProductos(lstP);
            float total = obtenerTotal(lstP);
            Console.WriteLine("Monto a pagar: " + total);
        }

        private static void ingresarProductos(List<Producto> lst)
        {
            string nombre;
            float precio;

            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();

            while(!nombre.Equals("fin"))
            {
                Console.WriteLine("Ingrese el precio del producto:");
                precio = float.Parse(Console.ReadLine());

                lst.Add(new Producto(nombre, precio));

                Console.WriteLine("Ingrese el nombre del producto:");
                nombre = Console.ReadLine();
            }
        }

        private static float obtenerTotal(List<Producto> lst)
        {
            float total = 0;
            float descuento = obtenerDescuento(lst);

            foreach (Producto item in lst)
            {
                total += item.getPrecio();
            }

            total = total - (total*descuento);

            return total;
        }

        private static float obtenerDescuento(List<Producto> lst)
        {
            return lst.Count() > 5 ? 0.1f : 0;
        }
    }
}
