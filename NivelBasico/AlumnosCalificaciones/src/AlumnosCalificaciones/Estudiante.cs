namespace AlumnosCalificaciones
{
    public class Estudiante
    {
        private string nombre;
        private float nota;

        public Estudiante(string n, float nota)
        {
            this.nombre = n;
            this.nota = nota;
        }

        public float getNota()
        {
            return this.nota;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}

