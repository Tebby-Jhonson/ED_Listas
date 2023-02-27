using System;
using System.Text;

namespace ListasCirculares
{
    internal class Lista
    {
        Nodo Origen { get; set; }

        public Lista() {
            Origen = null;
        }

        public void VaciarLista()
        {
            Origen = null;
        }

        public bool ValidarVacio()
        {
            return Origen == null;
        }

        public string RecorrerLista()
        {
            StringBuilder cadena = new StringBuilder();
            Nodo actual = Origen;
            while (!ReferenceEquals(actual.Siguiente,Origen) && actual != null)
            {
                cadena.Append(actual.Valor + "\n");
                actual = actual.Siguiente;
            }
            cadena.Append(actual.Valor + "\n");
            return cadena.ToString();
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            Nodo actual = Origen;
            if (Origen == null)
            {
                // Primer elemento
                Origen = nuevo;
                Origen.Siguiente = Origen;
                return;
            }
            else if (ReferenceEquals(actual.Siguiente, Origen))
            {
                // Segundo elemento
                Origen.Siguiente = nuevo;
                nuevo.Siguiente = Origen;
            }
            else
            {
                // Cualquier otro elemento
                while(!ReferenceEquals(actual.Siguiente, Origen))
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = Origen;

            }
        }

        public Nodo Buscar(string valor)
        {
            if (ValidarVacio())
            {
                return null;
            }
            Nodo actual = Origen;
            // Solo hay un elemento
            if (actual.Siguiente == Origen)
            {
                return actual;
            }
            actual = actual.Siguiente;
            while (!ReferenceEquals(actual, Origen))
            {
                if (actual.Valor == valor)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;

        }

        public void EliminarNodo(string valor)
        {
            Nodo actual = Origen;

            // Lista vacia
            if (ValidarVacio())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            // Solo hay un elemento
            if(actual.Siguiente == Origen)
            {
                VaciarLista();
            }

            while(!ReferenceEquals(actual.Siguiente,Origen))
            {
                if (actual.Siguiente.Valor == valor)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    if(ReferenceEquals(actual, Origen))
                        Origen = Origen.Siguiente;
                    return;
                }
            }

            Console.WriteLine("Nodo no encontrado");

        }
    }
}
