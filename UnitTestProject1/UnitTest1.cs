using CapaModelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VotacionWeb.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var votacion = new VotacionController();
            var votante = new Votante()
            {
                DocumentoIdentidad = string.Empty
            };
            var rpta = votacion.Ingreso(votante.DocumentoIdentidad);
            Assert.AreEqual(65765888, rpta);
        }
    }
}
