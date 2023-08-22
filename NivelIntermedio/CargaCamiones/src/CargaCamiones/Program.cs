using System;
using System.Collections.Generic;

namespace CargaCamiones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;

            // Respuesta del usuario si quiere ingresar más datos
            string rpta;

            List<Paquete> lstPaq = new List<Paquete>();

            // Ingreso de tamaños de los paquetes.
            Console.WriteLine("A continuación ingresara el tamaño de los paquetes.");
            Console.WriteLine("Si ya no quiere ingresar más paquetes presione (n/N/No/NO/no).");

            do
            {
                Console.WriteLine("Ingrese el tamaño del paquete:");
                num = int.Parse(Console.ReadLine());
                lstPaq.Add(new Paquete(num));

                while (num <= 0)
                {
                    Console.WriteLine("Recuerde que solo puede ingresar números enteros positivos.");
                    Console.WriteLine("Ingrese el tamaño del paquete:");
                    num = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("¿Ingresar más paquetes?. Si no desea ingrese (n/N/No/NO/no).");
                rpta = Console.ReadLine();
            } while (!rpta.Equals("n") && !rpta.Equals("N") && !rpta.Equals("No") && !rpta.Equals("NO") && !rpta.Equals("no"));


            // Ingreso del tamaño del camión.
            do
            {
                Console.WriteLine("Ingrese el tamaño del camión:");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0);

            Camion camion = new Camion(num);

            // Carga de paquetes en el camión.
            if (!Camion.ValidarTamanio(camion))
            {
                Console.WriteLine($"El camión es muy pequeño. Tiene un tamaño de {camion.TAMANIODISPONIBLE}.");
            }
            else if (validarCantidadPaquetes(lstPaq))
            {
                Console.WriteLine("¿Estas intentanto ingresar un(1) paquete al camión?. Minimo se puede cargar dos(2).");
            }
            else
            {
                agregarCarga(camion, lstPaq);
            }
        }

        // Tengo que tener una lista con más de un paquete.
        private static bool validarCantidadPaquetes(List<Paquete> lstPaq)
            => (lstPaq.Count <= 1);

        // Muestra el par de paquetes que se cargaria al camión.
        private static void agregarCarga(Camion camion, List<Paquete> lstPaq)
        {
            // Almacen de pares de paquetes potenciales a cargarse al camión.
            List<int[]> listaParesPaquetes = new List<int[]>();

            // Conversión de lista a array.
            int[] listToArray = new int[lstPaq.Count];
            int x = 0;

            foreach (Paquete item in lstPaq)
            {
                listToArray[x] = item.TAMANIO;
                x++;
            }

            // LLenado de pares de paquetes a la lista de pares de paquetes.
            for (int i = 0; i < listToArray.Length; i++)
            {
                for (int j = i + 1; j < listToArray.Length; j++)
                {
                    listaParesPaquetes.Add(new int[] { listToArray[i], listToArray[j] });
                }
            }

            // Solo nos quedamos con los pares de paquetes que caben en el 
            // camión.
            List<int[]> listaPaquetesAceptados = new List<int[]>();
            foreach (int[] item in listaParesPaquetes)
            {
                if (item[0] + item[1] <= camion.TAMANIODISPONIBLE)
                {
                    listaPaquetesAceptados.Add(item);
                }
            }

            // Retornamos el par de paquetes que cabe en el camión.
            int[] parPaquete = paqueteIdoneo(listaPaquetesAceptados);
            Console.WriteLine($"El par aceptado es {parPaquete[0]} y {parPaquete[1]}");
        }

        // Retorna el par de paquetes que se deberia de cargar al camión.
        private static int[] paqueteIdoneo(List<int[]> lst)
        {
            int[] parPaquete = lst.First();
            int mayor = lst.First()[0] + lst.First()[1];
            foreach (int[] item in lst)
            {
                if ((item[0] + item[1]) > mayor)
                {
                    mayor = item[0] + item[1];
                    parPaquete = item;
                }     
            }
           return parPaquete; 
        }
    }
}
