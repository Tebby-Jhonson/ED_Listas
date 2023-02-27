using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    public class Nodo
    {
        public string Valor;
        public Nodo Anterior;
        public Nodo Siguiente;

        public Nodo(string valor, Nodo anterior = null, Nodo siguiente = null)
        {
            Valor = valor;
            Anterior = anterior;
            Siguiente = siguiente;
        }
    }
}
