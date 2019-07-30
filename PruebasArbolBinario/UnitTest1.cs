using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api_REST.ArbolBinario;

namespace PruebasArbolBinario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            int[] nodos = new int[] { };

            Fachada fachada = new Fachada();
            NodoArbol nodoRaiz = fachada.CrearArbol(nodos);

            Assert.IsNull(nodoRaiz);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nodos = new int[] { 67, 39, 76, 28, 44, 29, 76, 74, 85, 83, 87};

            Fachada fachada = new Fachada();
            Assert.ThrowsException<System.Exception>(() => fachada.CrearArbol(nodos));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nodos = new int[] { 67 };

            Fachada fachada = new Fachada();
            NodoArbol nodoRaiz = fachada.CrearArbol(nodos);

            Assert.IsNotNull(nodoRaiz);
            Assert.AreEqual(nodoRaiz.Value, 67);
            Assert.IsNull(nodoRaiz.HijoDerecho);
            Assert.IsNull(nodoRaiz.HijoIzquierdo);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nodos = new int[] { 67, 39, 76};

            Fachada fachada = new Fachada();
            NodoArbol nodoRaiz = fachada.CrearArbol(nodos);

            Assert.IsNotNull(nodoRaiz);
            Assert.AreEqual(nodoRaiz.Value, 67);
            Assert.IsNotNull(nodoRaiz.HijoDerecho);
            Assert.AreEqual(nodoRaiz.HijoDerecho.Value, 76);
            Assert.IsNull(nodoRaiz.HijoDerecho.HijoDerecho);
            Assert.IsNull(nodoRaiz.HijoDerecho.HijoIzquierdo);
            Assert.IsNotNull(nodoRaiz.HijoIzquierdo);
            Assert.AreEqual(nodoRaiz.HijoIzquierdo.Value, 39);
            Assert.IsNull(nodoRaiz.HijoIzquierdo.HijoDerecho);
            Assert.IsNull(nodoRaiz.HijoIzquierdo.HijoIzquierdo);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nodos = new int[] { 67, 39, 76 };

            Fachada fachada = new Fachada();
            NodoArbol nodoRaiz = fachada.CrearArbol(nodos);

            Assert.IsNotNull(nodoRaiz);
            Assert.AreEqual(nodoRaiz.Value, 67);
            Assert.IsNotNull(nodoRaiz.HijoDerecho);
            Assert.AreEqual(nodoRaiz.HijoDerecho.Value, 76);
            Assert.IsNull(nodoRaiz.HijoDerecho.HijoDerecho);
            Assert.IsNull(nodoRaiz.HijoDerecho.HijoIzquierdo);
            Assert.IsNotNull(nodoRaiz.HijoIzquierdo);
            Assert.AreEqual(nodoRaiz.HijoIzquierdo.Value, 39);
            Assert.IsNull(nodoRaiz.HijoIzquierdo.HijoDerecho);
            Assert.IsNull(nodoRaiz.HijoIzquierdo.HijoIzquierdo);

            nodoRaiz = fachada.AdicionarNodoArbol(nodoRaiz, 28);
            Assert.AreEqual(nodoRaiz.HijoIzquierdo.Value, 39);
            Assert.IsNull(nodoRaiz.HijoIzquierdo.HijoDerecho);
            Assert.IsNotNull(nodoRaiz.HijoIzquierdo.HijoIzquierdo);
            Assert.AreEqual(nodoRaiz.HijoIzquierdo.HijoIzquierdo.Value, 28);
        }


        [TestMethod]
        public void TestMethod5()
        {
            int[] nodos = new int[] { 67, 39, 76, 28, 44, 29, 74, 85, 83, 87 };

            Fachada fachada = new Fachada();
            NodoArbol nodoRaiz = fachada.CrearArbol(nodos);
            int LCA = fachada.BuscarNodocomunMasCercano(nodoRaiz, 29, 44);
            Assert.AreEqual(LCA, 39);
            LCA = fachada.BuscarNodocomunMasCercano(nodoRaiz, 44, 85);
            Assert.AreEqual(LCA, 67);
            LCA = fachada.BuscarNodocomunMasCercano(nodoRaiz, 83, 87);
            Assert.AreEqual(LCA,85);
            LCA = fachada.BuscarNodocomunMasCercano(nodoRaiz, 28, 39);
            Assert.AreEqual(LCA, 39);
        }
    }
}
