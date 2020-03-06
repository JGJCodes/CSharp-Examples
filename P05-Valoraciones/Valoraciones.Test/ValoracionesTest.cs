using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test
{
    [TestClass]
    public class ValoracionesTest
    {
        [TestMethod]
        public void CalcularValoracionMaxTest()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(2);
;
            Assert.AreEqual(5,libro.MaximaValoracion());
        }

        [TestMethod]
        public void CalcularValoracionMinTest()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(2);
            
            Assert.AreEqual(2, libro.MinimaValoracion());
        }

        [TestMethod]
        public void CalcularValoracionPromedioTest()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(2);
            
            Assert.AreEqual(3.5f, libro.PromedioValoraciones());
        }
    }
}
