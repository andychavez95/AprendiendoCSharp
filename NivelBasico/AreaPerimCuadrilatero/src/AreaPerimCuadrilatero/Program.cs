using System;
using System.IO;

namespace AreaPerimCuadrilatero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float area, perimetro, largo, ancho;

            Console.WriteLine("Ingrese el largo del cuadrilatero:");
            largo = float.Parse(Console.ReadLine());
            largo = Math.Abs(largo);

            Console.WriteLine("Ingrese el ancho del cuadrilatero:");
            ancho = float.Parse(Console.ReadLine());
            ancho = Math.Abs(ancho);

            perimetro = (2 * largo) + (2 * ancho);
            area = ancho * largo;

            Console.WriteLine("El área del cuadrilatero es: " + area);
            Console.WriteLine("El perímetro del cuadrilatero es: " + perimetro);
        }
    }
}
