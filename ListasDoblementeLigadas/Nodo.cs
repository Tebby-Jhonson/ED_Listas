using System;

namespace ListasDoblementeLigadas
{
    public class Nodo
    {
        public string Valor { get; set; }

        public Nodo Anterior { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo(string valor, Nodo anterior = null, Nodo siguiente = null) 
        { 
            Valor = valor;
            Anterior = anterior;
            Siguiente = siguiente;
        }

        public void NodoAnterior()
        {
            if (Anterior == null)
                Console.WriteLine("El nodo no tiene nodo anterior");
            else
                Console.WriteLine(Anterior.Valor);
        }

        public void NodoSiguiente()
        {
            if (Siguiente == null)
                Console.WriteLine("El nodo no tiene nodo siguiente");
            else
                Console.WriteLine(Siguiente.Valor);
        }
    }
}
