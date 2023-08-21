using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxClientes
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;

        public Cliente(){}

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DNI { get; set; }

        private string Informacion
        {
            get 
            {
                return Nombre + " " + Apellido;
            }
        }

        public override string ToString()
        {
            return Informacion;
        }
    }
}
