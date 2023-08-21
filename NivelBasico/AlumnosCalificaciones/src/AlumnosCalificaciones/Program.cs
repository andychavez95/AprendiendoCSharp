using System.Collections;
using System.Text;
using System.IO;

namespace AlumnosCalificaciones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Estudiante> lstEstu = new List<Estudiante>();
            
            uint cant;

            Console.WriteLine("Ingrese la cantidad de estudiantes");
            cant = UInt32.Parse(Console.ReadLine());
            
            string nombreEstu;
            float notaEstu;

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante:");
                nombreEstu = Console.ReadLine();

                Console.WriteLine("Ingrese la nota del estudiante:");
                notaEstu = float.Parse(Console.ReadLine());

                lstEstu.Add(new Estudiante(nombreEstu, notaEstu));
            }

            imprimirEstudiantes(lstEstu);

            Console.WriteLine("La nota promedio es: " + notaProm(lstEstu));

            StringBuilder sb = new StringBuilder();
            
            Estudiante est = mayNota(lstEstu);
            sb.AppendLine("Estudiante con la nota más alta: " + est.getNombre() + ".");
            sb.AppendLine("Su nota fue: " + est.getNota());
            Console.WriteLine(sb.ToString());

            StringBuilder sb2 = new StringBuilder();
            est = minNota(lstEstu);
            sb2.AppendLine("Estudiante con la nota más baja: " + est.getNombre() + ".");
            sb2.AppendLine("Su nota fue: " + est.getNota());
            Console.WriteLine(sb2.ToString());
        }

        private static float notaProm(List<Estudiante> lst)
        {
            float promedio = 0;

            foreach (Estudiante item in lst)
            {
                promedio = promedio + item.getNota();
            }

            return promedio/lst.Count();
        }

        private static Estudiante mayNota(List<Estudiante> lst)
        {
            Estudiante estuMayNota = null;
            float mayor = lst.First().getNota();

            foreach(Estudiante estu in lst)
            {
                if(estu.getNota() >= mayor)
                {
                     estuMayNota = estu;
                }
            }

            return estuMayNota;
        }

        private static Estudiante minNota(List<Estudiante> lst)
        {
            Estudiante estu = null;
            float menorNota = lst.First().getNota();

            foreach(Estudiante item in lst)
            {
                if(item.getNota() <= menorNota)
                {
                     estu = item;
                }
            }

            return estu;
        }

        private static void imprimirEstudiantes(List<Estudiante> lst)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("        LISTA DE ESTUDIANTES    ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("        Nombre            Nota         ");
            Console.WriteLine("---------------------------------------");
            foreach(Estudiante item in lst)
            {
                Console.WriteLine("    " + item.getNombre() + "            " + item.getNota());
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
        }
    }
}

