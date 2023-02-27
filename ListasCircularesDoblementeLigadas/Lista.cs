using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Lista
    {
        Nodo Origen;

        public Lista()
        {
            Origen = null;
        }

        public bool ValidarVacio() {
            return Origen == null;
        }

        public void VaciarLista()
        {
            Origen = null;
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if(ValidarVacio())
            {
                // Primer elemento
                Origen = nuevo;
                Origen.Siguiente = Origen;
                Origen.Anterior = Origen;
                return;
            }
            if(ReferenceEquals(Origen,Origen.Siguiente) && ReferenceEquals(Origen, Origen.Anterior))
            {
                Origen.Siguiente = nuevo;
                Origen.Anterior = nuevo;
                nuevo.Siguiente = Origen;
                nuevo.Anterior = Origen;
                return;
            }
            Nodo actual = Origen.Siguiente;
            while (!ReferenceEquals(actual.Siguiente,Origen))
            {
                actual = actual.Siguiente;
            }
            nuevo.Anterior = actual;
            nuevo.Siguiente = Origen;
            actual.Siguiente = nuevo;
            Origen.Anterior = nuevo;
        }

        public void EliminarNodo(string valor)
        {
            if (ValidarVacio()) return;
            if (ReferenceEquals(Origen, Origen.Siguiente) && ReferenceEquals(Origen, Origen.Anterior))
            {
                VaciarLista();
            }
            Nodo actual = Origen;
            while (!ReferenceEquals(actual.Siguiente, Origen))
            {
                if(actual.Valor == valor)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                    actual.Siguiente.Anterior = actual.Anterior;
                    if (ReferenceEquals(actual, Origen))
                    {
                        Origen = Origen.Siguiente;
                    }
                    return;
                }
                actual = actual.Siguiente;
            }
        }

        public Nodo Buscar(string valor)
        {
            if (ValidarVacio()) return null;
            Nodo actual = Origen;

            while (!ReferenceEquals(actual.Siguiente, Origen))
            {
                if(actual.Valor == valor)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public string RecorrerLista()
        {
            StringBuilder cadena = new StringBuilder();
            Nodo actual = Origen;
            while (!ReferenceEquals(actual.Siguiente, Origen) && actual != null)
            {
                cadena.Append(actual.Valor + "\n");
                actual = actual.Siguiente;
            }
            cadena.Append(actual.Valor + "\n");
            return cadena.ToString();
        }



    }
}
