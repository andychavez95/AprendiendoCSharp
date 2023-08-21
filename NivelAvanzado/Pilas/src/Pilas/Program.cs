namespace Pilas
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url1, url2, url3;
            url1 = "https://www.wikipedia.org";
            url2 = "https://www.gnu.org";
            url3 = "https://www.linux.org";

            Pila p = new Pila();
            URL u1 = new URL(url1);
            URL u2 = new URL(url2);
            URL u3 = new URL(url3);

            p.apilar(u1);
            p.apilar(u2);
            p.apilar(u3);
        }
    }
}
