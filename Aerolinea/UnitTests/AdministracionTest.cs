using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace UnitTests
{
    [TestClass]
    public class AdministracionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckearSiClienteExiste_CuandoElClienteEsNull_DeberiaRetornarNullArgument()
        {
            //Arrange - Preparar el caso de prueba
            Cliente cliente = null;
            bool ret = false;
            //Act - Invocar el metodo a probar

            ret = Administracion.CheckearSiClienteExiste(cliente);

            Assert.AreEqual(false, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckearSiAvionExiste_CuandoElAvionEsNull_DeberiaRetornarNullArgument()
        {
            //Arrange - Preparar el caso de prueba
            Avion avion = null;
            bool ret = false;
            //Act - Invocar el metodo a probar

            ret = Administracion.CheckearSiAvionExiste(avion);

            Assert.AreEqual(false, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckearSiVueloExiste_CuandoElVueloEsNull_DeberiaRetornarNullArgument()
        {
            //Arrange - Preparar el caso de prueba
            Vuelo vuelo = null;
            bool ret = false;
            //Act - Invocar el metodo a probar

            ret = Administracion.CheckearSiVueloExiste(vuelo);

            Assert.AreEqual(false, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckearSiPasajeExiste_CuandoElVueloEsNull_DeberiaRetornarNullArgument()
        {
            //Arrange - Preparar el caso de prueba
            Vuelo vuelo = null;
            bool ret = false;
            //Act - Invocar el metodo a probar

            ret = Administracion.CheckearSiPasajeExiste(40000000,vuelo);

            Assert.AreEqual(false, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckearSiPasajeExiste_CuandoElDniEs0_DeberiaRetornarException()
        {
            //Arrange - Preparar el caso de prueba
            Vuelo vuelo = null;
            bool ret = false;
            //Act - Invocar el metodo a probar

            ret = Administracion.CheckearSiPasajeExiste(0,vuelo);

            Assert.AreEqual(false, ret);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObtenerVendedor_CuandoNombreOPaswwordEsNull_DeberiaRetornarNullArgument()
        {
            //Arrange - Preparar el caso de prueba
            string nombre = string.Empty;
            string password = string.Empty;
            Vendedor vendedor = null;
            //Act - Invocar el metodo a probar

            vendedor = Administracion.ObtenerVendedor(nombre, password);

            Assert.AreEqual(null, vendedor);
        }
    }
}
