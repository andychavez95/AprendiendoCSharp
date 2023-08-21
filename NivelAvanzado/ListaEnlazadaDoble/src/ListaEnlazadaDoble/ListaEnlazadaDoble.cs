namespace ListaEnlazadaDoble
{
    internal class ListaEnlazadaDoble
    {
        private Nodo inicio;
        private int longitud;

        //Retorna si la lista está vacia o no.
        private bool vacio() { return this.longitud == 0; }

        //Retorna la cantidad total de nodos en la lista.
        public int cantTotal() { return this.longitud; }

        private void insertarinicio(int elemento)
        {
            Nodo nuevoNodo = new Nodo(elemento);
            this.inicio = nuevoNodo;
        }

        private void insertarFinal(int elemento)
        {
            // Nuevo nodo a agregar a la lista.
            Nodo nuevoNodo = new Nodo(elemento);
            
            // Nodo apuntando al inicio de la lista.
            Nodo puntero = this.inicio;

            while (puntero.nodoSig() is not null)
            {
                puntero = puntero.nodoSig();
            }

            // El nodo anterior al nuevo nodo es el ultimo nodo que estaba en
            // la lista.
            nuevoNodo.setAntNodo(puntero);

            // El nodo siguiente al ultimo nodo de la lista es el nodo que se
            // ha ingresado.
            puntero.setSigNodo(nuevoNodo);
        }

        private void msgElemEnc(Nodo nodo)
        {
            Console.WriteLine("Elemento encontrado:");
            Console.WriteLine("El elemento es: " + nodo.obtElem());
            nodo.obtElemAnt();
            nodo.obtElemSig();
        }

        public void agregar(int elemento)
        {
            if (this.vacio())
            {
                this.insertarinicio(elemento);
            }
            else
            {
                this.insertarFinal(elemento);
            }
            this.longitud++;
        }

        public void buscElem(int id)
        {
            if (this.vacio())
            {
                Console.WriteLine("No hay nada que buscar. La lista está vacia");
            }
            else if (this.inicio.obtElem() == id)
            {
                this.msgElemEnc(this.inicio);
            }
            else
            {
                Nodo p = this.inicio.nodoSig();

                while (p is not null  && (p.nodoAnt() is not null || p.nodoSig() is not null))
                {
                    if (p.obtElem() == id)
                    {
                        this.msgElemEnc(p);
                    }
                    p = p.nodoSig();
                } 
            }
        }

        /* public void imprimirLista()
        {
            Nodo puntero = this.inicio;
            int i = 0;
            while (i < this.longitud)
            {

                Console.WriteLine("************************************");

                if (puntero.anterior == null)
                {
                    Console.WriteLine("Anterior: No existe.");
                }
                else
                {
                    Console.WriteLine("Anterior: " + puntero.anterior.getElemento());
                }

                Console.WriteLine("Actual: " + puntero.getElemento());

                if (puntero.siguiente == null)
                {
                    Console.WriteLine("Siguiente: No existe.");
                }
                else
                {
                    Console.WriteLine("Siguiente: " + puntero.siguiente.getElemento());
                }

                Console.WriteLine("************************************");
                i++;
                puntero = puntero.siguiente;
            }
        } */
    }
}
