namespace ABB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(4, "Andy", 29);
            Persona p2 = new Persona(12, "Rosmery", 28);

            ABB abb = new ABB();

            // Inserto una persona al aŕbol.
            abb.add(p1);

            // Inserto a la misma persona en el árbol. Debe de decirme que no 
            // está permitido Ingresar personas repetidas. 
            abb.add(p1);
            
           // Pregunto si el la raíz es una hoja.
           Console.WriteLine("¿El árbol NO tiene hojas?: " + abb.treeWithoutSheets());

            // Inserto otra persona al árbol
            abb.add(p2);

            // Vuelvo a preguntar si la raíz del árbol es una hoja.
           Console.WriteLine("¿El árbol NO tiene hojas?: " + abb.treeWithoutSheets());

           // Busca a una persona en el árbol por su id.
           Console.WriteLine("¿La persona con id \"100\" existe?: " + abb.exists(100));
           Console.WriteLine("¿La persona con id \"4\" existe?: " + abb.exists(4));
        }
    }
}
