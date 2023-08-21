namespace FibonacciIterador
{
    public class SecuenciaFibonacci
    {
        int[] secueFib;

        public SecuenciaFibonacci(int length)
        {
            this.secueFib = new int[length];
        }

        public void agregarUno()
        {
            this.secueFib[0] = 0;
        }

        public void agregarDos()
        {
            this.secueFib[0] = 0;
            this.secueFib[1] = 1;
        }

        public int[] getSecueFib()
        {
            return this.secueFib;
        }
    }
}

