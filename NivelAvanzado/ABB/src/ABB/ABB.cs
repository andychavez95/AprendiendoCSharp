using System;

namespace ABB
{
        public class ABB
        {
            private Persona p;
            private ABB izq, der; 
            
            public bool isEmpty()
            {
                return this.p is null;
            }

            public bool treeWithoutSheets()
            {
                return this.p is not null && this.izq is null && this.der is null;
            }

            public void add(Persona per)
            {
                if (this.isEmpty())
                {
                    /*
                     * Si el nodo no tiene una persona dentro de él, en otras
                     * palabras "p" no tiene un valor, "p" valdrá el valor del
                     * parametro "per".
                     */
                    this.p = per;
                }
                else
                {
                    if (this.p.compare(per) > 0)
                    {
                        /*
                         * Si el id de la persona "per" es mayor que el valor 
                         * del id de la persona con la que se encuentra en el 
                         * nodo, "per" ira por el camino derecho.
                         */
                        if (this.der is null) { this.der = new ABB(); }
                        this.der.add(per);
                    }
                    else if (this.p.compare(per) < 0)
                    {
                        /*
                         * Si el id de la persona "per" es mayor que el valor 
                         * del id de la persona con la que se encuentra en el 
                         * nodo, "per" ira por el camino derecho.
                         */
                        if (this.izq is null) { this.izq = new ABB(); }
                        this.izq.add(per);
                    }
                    else
                    {
                        /*
                         * Si el id de la persona "per" y el id de la persona
                         * que está en el nodo son los mismo arroja mensaje
                         * lineas abajo.
                         */
                        Console.WriteLine("Existe una persona con el mismo id.");
                    }
                }
            }

            public bool exists(int id)
            {
                if (this.p is null)
                {
                    return false;
                }
                else 
                {
                    if (this.p.compareId(id) == 0) 
                    {
                        return true;
                    }
                    else if (this.p.compareId(id) > 0)
                    {
                        if (this.der is not null) { return this.der.exists(id); }
                        else return false;
                    }
                    else if (this.p.compareId(id) < 0)
                    {
                        if (this.izq is not null) { return this.izq.exists(id); }
                        else return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            public Persona getPerson(int id)
            {
                if (this.p is not null)
                {
                    if (this.p.compareId(id) == 0)
                    {
                        return this.p;
                    }
                    else if (this.p.compareId(id) > 0)
                    {
                        if (this.der is not null) { return this.getPerson(id); }
                        else return null;
                    }
                    else if (this.p.compareId(id) < 0)
                    {
                        if (this.der is not null) { return this.getPerson(id); }
                        else return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
}

