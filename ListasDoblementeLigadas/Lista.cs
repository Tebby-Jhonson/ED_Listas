using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        public Nodo Primero { get; set; }
        public Nodo Ultimo { get; set; }

        public Lista() {
            Primero = null;
            Ultimo = null;
        }

        public bool ValidarVacio()
        {
            return Primero == null && Ultimo == null;
        }

        public void VaciarLista()
        {
            Ultimo = null;
            Primero = null;
        }

        public string RecorrerLista()
        {
            StringBuilder valores = new StringBuilder();
            Nodo actual = Primero;
            while (actual != null)
            {
                valores.Append(actual.Valor + "\n");
                actual = actual.Siguiente;
            }
            return valores.ToString();
        }

        public void AgregarNodoAlFinal(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (ValidarVacio())
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        public void AgregarNodoAlPrincipio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (ValidarVacio())
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero.Anterior = nuevo;
                Primero = nuevo;
            }
        }

        public Nodo Buscar(string valor)
        {
            if (!ValidarVacio())
            {
                Nodo actual = Primero;
                while (actual != null)
                {
                    if (actual.Valor == valor)
                    {
                        return actual;
                    }
                }
            }
            return null;
        }

        public Nodo BuscarPorIndice(int indice)
        {
            int index = 0;
            Nodo actual = Primero;
            if (!ValidarVacio())
            {
                while (actual != null  && index < indice)
                {
                    actual = actual.Siguiente;
                    index++;
                }
                if(index == indice)
                {
                    return actual;
                }
            }
            return null;
        }

        public void BorrarNodo(string valor)
        {
            if(ValidarVacio())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }

            Nodo actual = Primero;
            while (actual != null && actual.Valor != valor )
            {
                actual = actual.Siguiente;
            } 
            if (actual == null)
            {
                Console.WriteLine("No se ha encontrado el nodo deseado");
                return;
            }
            if (actual.Anterior == null)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                actual.Anterior.Siguiente = actual.Siguiente;
            }
            if(actual.Siguiente == null)
            {
                Ultimo = Ultimo.Anterior;
            }
            else
            {
                actual.Siguiente.Anterior = actual.Anterior;
            }
        }
    }
}
