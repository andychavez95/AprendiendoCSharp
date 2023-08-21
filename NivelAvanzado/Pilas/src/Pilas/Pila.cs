namespace Pilas
{
    public class Pila
    {
        private Node cima;
        private int length = 0;

        private bool isEmpty() { return this.length == 0; }
        private int getLength() { return this.length; }
        
        public void apilar(URL url)
        {
            // Creamos el nodo que será parte de la pila.
            Node newNode = new Node(url);
            newNode.setNextNode(this.cima);
            this.cima = newNode;
            this.length++;
        }

        public void desapilar()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("La pila está vacia.");
            }
            else
            {
                Node p = this.cima;
                this.cima = p.getNextNode();
                p.setNextNode(null);
                this.length--;
            }
        }

        public string getLastURL()
        {
            if(!this.isEmpty())
            {
                return this.cima.getURL();
            }
            else
            {
                return null;
            }
        }
    }
}
