using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_REST.ArbolBinario
{
    public class NodoArbol
    {
        public int Value { get; set; }
        public int Nivel { get; set; }
        public NodoArbol Padre { get; set;  }
        public NodoArbol HijoDerecho { get; set; }
        public NodoArbol HijoIzquierdo { get; set; }

        public NodoArbol(int value, NodoArbol padre, NodoArbol nodoizquierdo, NodoArbol nodoDerecho)
        {
            Value = value;
            Padre = padre;
            HijoIzquierdo = nodoizquierdo;
            HijoDerecho = nodoDerecho;
        }
    }
}