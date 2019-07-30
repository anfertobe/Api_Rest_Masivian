using System;
using System.Collections.Generic;
using System.Linq;

namespace Api_REST.ArbolBinario
{
    public class Arbol
    {
        public NodoArbol AgregarNodo(int value, NodoArbol nodo,  int nivel)
        {
            if (nodo == null)
            {
                nodo = new NodoArbol(value, null, null, null);
                nodo.Nivel = nivel;
            }
            else if (value < nodo.Value)
            {
                nivel++;
                nodo.HijoIzquierdo = AgregarNodo(value, nodo.HijoIzquierdo, nivel);

            }
            else if (value > nodo.Value)
            {
                nivel++;
                nodo.HijoDerecho = AgregarNodo(value, nodo.HijoDerecho, nivel);
            }
            else
            {
                throw new Exception("El dato ya existe en el arbol");
            }

            return nodo;
        }

        public NodoArbol CrearArbol(int[] values)
        {
            NodoArbol arbol = null;

            foreach (int value in values)
            {
                arbol = AgregarNodo(value, arbol, 0);
            }

            return arbol;
        }

        public int BuscarNodoComunMasCercano(NodoArbol root, int value1, int value2)
        {
            NodoArbol nodoObjetivo = null;

            var result = this.recurseTree(root, value1, value2, ref nodoObjetivo);
            var lca = -1;
            if (result)
                lca = nodoObjetivo.Value;

            return lca;
        }

        private bool recurseTree(NodoArbol nodoActual, int value1, int value2, ref NodoArbol nodoObjetivo)
        {
            if (nodoActual == null)
                return false;

            int left = this.recurseTree(nodoActual.HijoIzquierdo, value1, value2, ref nodoObjetivo) ? 1 : 0;

            int right = this.recurseTree(nodoActual.HijoDerecho, value1, value2, ref nodoObjetivo) ? 1 : 0;

            int mid = (nodoActual.Value == value1 || nodoActual.Value == value2) ? 1 : 0;

            if (mid + left + right >= 2)
                nodoObjetivo = nodoActual;

            return (mid + left + right > 0);
        }
    }
}