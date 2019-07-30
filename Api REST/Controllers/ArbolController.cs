using System.Collections.Generic;
using System.Web.Http;

namespace Api_REST.Controllers
{
    [RoutePrefix("api/Arbol")]
    public class ArbolController : ApiController
    {
        private ArbolBinario.Fachada fachada = new ArbolBinario.Fachada();

        [Route("CreateTree")]
        public ArbolBinario.NodoArbol CreateTree(int[] nodos)
        {
            return fachada.CrearArbol(nodos);
        }

        [Route("LowestCommonAncestor")]
        public int GetLowestCommonAncestor(ArbolBinario.NodoArbol nodo, int value1, int value2)
        {
            return fachada.BuscarNodocomunMasCercano(nodo, value1, value2); ;
        }

        [HttpPut]
        [Route("AddNodeTree")]
        public ArbolBinario.NodoArbol AddNodeTree(ArbolBinario.NodoArbol nodo, int value)
        {
            return fachada.AdicionarNodoArbol(nodo, value);
        }
    }
}
