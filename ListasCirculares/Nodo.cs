namespace ListasCirculares
{
    public class Nodo
    {
        public Nodo Siguiente { get; set; }
        public string Valor { get; set; }

        public Nodo(string valor, Nodo siguiente = null)
        {
            Valor = valor;
            Siguiente = siguiente;
        }

    }
}
