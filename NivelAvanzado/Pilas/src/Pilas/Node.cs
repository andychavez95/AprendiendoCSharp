namespace Pilas
{
    public class Node
    {
        private URL url;
        private Node next;

        public Node(URL url)
        {
            this.url = url;
        }

        public string getURL()
        {
            return this.url.getURL();
        }

        public Node getNextNode()
        {
            return this.next;
        }

        public void setNextNode(Node next)
        {
            this.next = next;
        }
    }
}

