using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labNetPractica2.ModifiedExceptions;

namespace labNetPractica2.Logica.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void PuntoTres_ExcepcionDesdeLogic_a_PresentacionTest__NUMEROSCORRECTOS__ResultadoOK()
        {
            Logic logic = new Logic();
            string numerouno = "1";
            string numerodos = "2";
            decimal resultadoEsperado = 0.5M;
            decimal resultadoDevuelto;


            resultadoDevuelto = Decimal.Parse(logic.PuntoTres_ExcepcionDesdeLogic_a_Presentacion(numerouno, numerodos).ToString());


            Assert.AreEqual(resultadoEsperado, resultadoDevuelto);
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void PuntoTres_ExcepcionDesdeLogic_a_PresentacionTest__NUMEROSNulos__ArrojaException()
        {
            Logic logic = new Logic();

            Decimal.Parse(logic.PuntoTres_ExcepcionDesdeLogic_a_Presentacion("", "").ToString());


           
        }


        [TestMethod()]
        public void PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_PresentacionTest__NUMEROSCORRECTOS__ResultadoOK()
        {
            Logic logic = new Logic();
            string numerouno = "1";
            string numerodos = "2";
            decimal resultadoEsperado = 0.5M;
            decimal resultadoDevuelto;


            resultadoDevuelto = Decimal.Parse(logic.PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_Presentacion(numerouno, numerodos).ToString());


            Assert.AreEqual(resultadoEsperado, resultadoDevuelto);
        }


        [TestMethod()]
        [ExpectedException(typeof(BadInputException))]
        public void PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_PresentacionTest__NUMEROSNulos__ArrojaException()
        {
            Logic logic = new Logic();

            Decimal.Parse(logic.PuntoCuatro_ExcepcionPersonalizadaDesdeLogic_a_Presentacion("", "").ToString());



        }

    }
}