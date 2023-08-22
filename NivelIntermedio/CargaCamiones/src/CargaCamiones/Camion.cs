using System;

namespace CargaCamiones
{
    public sealed class Camion
    {
        private int tamanioTotal;
        private int tamanioDisponible;

        public Camion(int tamanioTotal)
        {
            this.tamanioTotal = tamanioTotal;
            tamanioDisponible = tamanioTotal - 30;
        }

        public static bool ValidarTamanio(Camion camion)
        {
            return (camion.TAMANIODISPONIBLE > 0);
        }

        public int TAMANIODISPONIBLE
        {
            get => tamanioDisponible;
        }
    }
}
