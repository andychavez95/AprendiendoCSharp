namespace AreasFigurasGeo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string opcion;
            Console.WriteLine("****************************************");
            Console.WriteLine("Elija la figura para obtener su área:");
            Console.WriteLine("1.- Cuadrado.");
            Console.WriteLine("2.- Triángulo.");
            Console.WriteLine("3.- Circulo.");
            Console.WriteLine("****************************************");

            do
            {
                Console.WriteLine("Seleccione una opción.");
                opcion = Console.ReadLine();
            } while (!opcion.Equals("1") && !opcion.Equals("2") && !opcion.Equals("3"));

            switch (opcion)
            {
                case "1":
                    areaCuadrado();
                    break;
                case "2":
                    areaTriangulo();
                    break;
                case "3":
                    areaCirculo();
                    break;
            }
        }

        private static void areaCuadrado()
        {
            Console.WriteLine("Ingrese la longuitud del lado del cuadrado:");
            float lado = float.Parse(Console.ReadLine());

            float area = lado * lado;

            Console.WriteLine("El área es " + area + " centrimetros cuadrados.");
        }

        private static void areaTriangulo()
        {
            Console.WriteLine("Ingrese la longuitud de la base del triángulo:");
            float baseTri = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longuitud de la altura del triángulo:");
            float altura = float.Parse(Console.ReadLine());

            float area = (baseTri * altura) / 2;

            Console.WriteLine("El área es " + area + " centrimetros cuadrados.");
        }

        private static void areaCirculo()
        {
            Console.WriteLine("Ingrese la longuitud del radio de la circulo:");
            float radio = float.Parse(Console.ReadLine());

            float area = (float) Math.PI * radio * radio;

            Console.WriteLine("El área es " + area + " centrimetros cuadrados.");
        }
    }
}

