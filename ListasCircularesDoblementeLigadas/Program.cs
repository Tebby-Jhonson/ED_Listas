using System;

namespace ListasCircularesDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cero");

            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Eliminando Uno");
            lista.EliminarNodo("Uno");
            Console.WriteLine(lista.RecorrerLista());
            

            Console.WriteLine("Buscando Dos");
            Nodo busqueda = lista.Buscar("Dos");
            Console.WriteLine(busqueda.Valor);
            Console.ReadKey();
        }
    }
}
