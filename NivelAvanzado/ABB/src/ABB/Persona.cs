namespace ABB
{
    public class Persona
    {
        private int id;
        private string nombre;
        private int edad;

        public Persona(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNomb()
        {
            return this.nombre;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void setNomb(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        // Compara los id de dos objetos. Útil para saber si un nodo es igual
        // a otro que pretende ingresar al ABB.        
        public int compare(Persona p)
        {
            if (this.getId() == p.getId())
            {
                return 0;
            }
            else if (this.getId() < p.getId())
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la derecha.
                return 1;
            }
            else
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la izquierda.
                return -1;
            }
        }

        public int compareId(int id)
        {
            if (this.getId() == id)
            {
                return 0;
            }
            else if (this.getId() < id)
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la derecha.
                return 1;
            }
            else
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la izquierda.
                return -1;
            }
        }
    }
}

