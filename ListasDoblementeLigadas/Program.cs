using System;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodoAlFinal("Uno");
            lista.AgregarNodoAlFinal("Dos");
            lista.AgregarNodoAlPrincipio("Tres");
            lista.AgregarNodoAlFinal("Cuatro");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Pruebas de busqueda");
            // Buscar por indice, se espera salga Dos
            Console.WriteLine("Busqueda por indice");
            Nodo busquedaPorIndice = lista.BuscarPorIndice(2);
            if (busquedaPorIndice != null)
                Console.WriteLine(busquedaPorIndice.Valor);
            else
                Console.WriteLine("No encontrado");

            Console.WriteLine("Busqueda");
            Nodo nodoBusqueda = lista.Buscar("Tres");
            if (nodoBusqueda != null)
                Console.WriteLine(nodoBusqueda.Valor);
            else
                Console.WriteLine("No encontrado");

            // Buscar el anterior o siguiente se puede limitar a buscar el de interes y acceder a un metodo que los muestra
            Console.WriteLine("Busqueda para obtener anterior y siguente");
            Nodo buscarLados = lista.Buscar("Uno");
            buscarLados.NodoAnterior();
            buscarLados.NodoSiguiente();

            Console.WriteLine("Eliminando el Dos");
            lista.BorrarNodo("Dos");
            Console.WriteLine(lista.RecorrerLista());

            Console.ReadKey();
        }
    }
}
