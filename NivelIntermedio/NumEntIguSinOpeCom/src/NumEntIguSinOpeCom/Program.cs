/*
 * Determinar si dos números enteros son iguales, sin utilizar operadores
 * de comparación ni de suma o resta
 */

using System.IO;
using System.Collections;

namespace NumEntIguSinOpeCom
{
    public class Program
    {
        static void Main(string[] args)
        {
           bool iguales;

           iguales = igualesM1(3, 4);
           Console.WriteLine("¿Los números son iguales?: " + iguales);

           iguales = igualesM2(3, 3);
           Console.WriteLine("¿Los números son iguales?: " + iguales);

           iguales = igualesM4(3, 3);
           Console.WriteLine("¿Los números son iguales?: " + iguales);
        }

        private static bool igualesM1(int a, int b)
        {
            bool iguales = false;
            iguales = Convert.ToBoolean(a/b);
            return iguales;
        }

        private static bool igualesM2(int a, int b)
        {
            bool p1 = Convert.ToBoolean(a/b);
            bool p2 = Convert.ToBoolean(b/a);

            return !((!p1 && p2) || (p1 && !p2));
        }

        private static bool igualesM3(int a, int b)
        {
            HashSet<int> lista = new HashSet<int>();
            lista.Add(a);
            lista.Add(b);

            return Convert.ToBoolean(lista.Count);
        }

        private static bool igualesM4(int a, int b)
        {
            Dictionary<int, bool> lista = new Dictionary<int, bool>();
            lista.Add(a, false);

            try
            {
                lista.Add(b, true);
            }
            catch (System.Exception)
            {
                return true;
            }

            return lista[a];
        }
    }
}
