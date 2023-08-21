namespace ValidarPassword
{
    public class Program
    {
        public static void Main(string[] args)
        {
           string password;
            
           Console.WriteLine("Ingrese su contraseña:");
           password = Console.ReadLine();

           validarPassword(password);
        }

        /*
         * Requisitos de la contraseña:
         * Longuitud de 8 caracteres.
         * Debe tener, al menos, una letra mayúscula.
         * Debe tener, al menos, una letra minúscula.
         * Debe tener un dígito.
         */
        private static void validarPassword(string p)
        {
            if (p.Length >= 8)
            {
                if (validMayus(p) && validMinus(p) && validDigit(p))
                {
                    Console.WriteLine("Ir a login...");
                }
                else
                {
                    Console.WriteLine("No cumple con los requisitos de complejidad.");
                }
            }
            else
            {
                Console.WriteLine("La contraseña tiene menos de 8 caracteres.");
            }
        }

        private static bool validDigit(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool validMayus(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool validMinus(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
