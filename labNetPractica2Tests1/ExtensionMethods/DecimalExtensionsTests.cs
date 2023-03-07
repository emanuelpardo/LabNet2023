using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.ExtensionMethods.Tests
{
    [TestClass()]
    public class DecimalExtensionsTests
    {
        [TestMethod()]
        public void DividirPorCeroTest_DivideporCERO_ArrojaResultadoCeroyMensajeExcepcion()
        {
            decimal dividendo = 1;
            decimal resultadoesperado = 0;
            string mensajeesperado = "Intento de dividir por cero.";

            var (resultadodevuelto,mensajedevuelto) = dividendo.DividirPorCero();

            Assert.AreEqual(resultadoesperado, resultadodevuelto);
            StringAssert.Contains(mensajedevuelto, mensajeesperado);
        }


        [TestMethod()]
        public void DividirTest_DivisionNormal_ResultadoOk()
        {
            decimal dividendo = 1;
            decimal divisor = 0.5M;
            decimal resultadoesperado = 2;

            var (resultadodevuelto, mensajedevuelto) = dividendo.Dividir(divisor);

            Assert.AreEqual(resultadoesperado, resultadodevuelto);
            StringAssert.Equals(mensajedevuelto, "");
        }


        [TestMethod()]
        public void DividirTest_DivididoporCero_ArrojaResultadoCeroyMensajeExcepcion()
        {
            decimal dividendo = 1;
            decimal divisor = 0;
            decimal resultadoesperado = 0;
            string mensajeesperado = "Solo STEVEN SEAGAL puede divir por 0";

            var (resultadodevuelto, mensajedevuelto) = dividendo.Dividir(divisor);

            Assert.AreEqual(resultadoesperado, resultadodevuelto);
            StringAssert.Equals(mensajedevuelto, mensajeesperado);
        }

    }


}