using System;

namespace CargaCamiones
{
    public sealed class Paquete
    {
        private int tamanio;

        public Paquete(int tamanio)
        {
            this.tamanio = tamanio;
        }

        public int TAMANIO
        {
            get => tamanio;
        }
    }
}
