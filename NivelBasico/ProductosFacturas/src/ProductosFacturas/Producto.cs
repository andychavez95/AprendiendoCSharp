namespace ProductosFacturas
{
    public class Producto
    {
        private string nombre;
        private float precio;

        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public float getPrecio()
        {
            return this.precio;
        }
    }
}
