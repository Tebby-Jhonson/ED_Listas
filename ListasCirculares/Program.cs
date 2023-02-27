using System;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            // En este caso agregar al final y al principio son la misma operacion
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cero");

            string valores = lista.RecorrerLista();
            Console.WriteLine(valores);

            lista.EliminarNodo("Dos");
            Console.WriteLine(lista.RecorrerLista());

            Nodo busqueda = lista.Buscar("Cero");
            if (busqueda != null)
                Console.WriteLine(busqueda.Valor);
            else
                Console.WriteLine("No encontrado");

            Console.ReadKey();

        }
    }
}
