using System.Collections.Generic;

namespace Api_REST.ArbolBinario
{
    public class Fachada
    {
        private Arbol arbol = new Arbol();

        public NodoArbol CrearArbol(int[] nodos)
        {
            if (nodos == null || nodos.Length == 0)
                return null;
            return arbol.CrearArbol(nodos);
        }

        public NodoArbol AdicionarNodoArbol(NodoArbol nodo, int value)
        {
            return arbol.AgregarNodo(value, nodo, 0);
        }

        public int BuscarNodocomunMasCercano(NodoArbol nodo, int value1, int value2)
        {
            return arbol.BuscarNodoComunMasCercano(nodo, value1, value2);
        }
    }
}