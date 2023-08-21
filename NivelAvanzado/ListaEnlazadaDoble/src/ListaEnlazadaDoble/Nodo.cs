namespace ListaEnlazadaDoble
{
    internal class Nodo
    {
        private int elemento;
        private Nodo anterior;
        private Nodo siguiente;

        public Nodo (int elemento) {
            this.elemento = elemento;
            this.anterior = null;
            this.siguiente = null;
        }

        public int obtElem()
        {
            return this.elemento;
        }

        public Nodo nodoAnt()
        {
            return this.anterior;
        }

        public Nodo nodoSig()
        {
            return this.siguiente;
        }

        public void obtElemAnt()
        {
            if (this.nodoAnt() is null)
            {
                Console.WriteLine("No hay un elemento anterior a este");
            }
            else
            {
                Console.WriteLine("El elemento anterior es: " + this.nodoAnt().obtElem());
            }
        }

        public void obtElemSig()
        {
            if (this.nodoSig() is null)
            {
                Console.WriteLine("No hay un elemento siguiente a este.");
            }
            else
            {
                Console.WriteLine("El elemento siguiente es: " + this.nodoSig().obtElem());
            }
        }

        public void setAntNodo(Nodo ant)
        {
            this.anterior = ant;
        }

        public void setSigNodo(Nodo sig)
        {
            this.siguiente = sig;
        }
    }
}
