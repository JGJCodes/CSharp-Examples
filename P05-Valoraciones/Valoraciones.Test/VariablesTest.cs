using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test
{
    /// <summary>
    /// Descripción resumida de VariablesTest
    /// </summary>
    [TestClass]
    public class VariablesTest
    {
        /*Tipos de variables
         * Referencia
         * Valor
         * Estructura
         * Enum
         */


        [TestMethod]
        public void ReferenciaTest()
        {
            LibroValoraciones l1 = new LibroValoraciones();
            LibroValoraciones l2 = l1;
            l1.AgregarValoracion(3);

            Assert.AreEqual(l1,l2);
        }

        [TestMethod]
        public void ValorTest()
        {
            int l1 = 10;
            int l2 = l1;
            //l1=20;

            Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void EstructuraTest()
        {
            Vector3D l1;
            l1.x = 1;
            Vector3D l2;
            l1.x=4;

            //Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void EnumTest()
        {
            Idioma l1 = Idioma.CHN;
            Idioma l2 = l1;
           // l1 = Idioma.ENG;

            Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void InmutableTest()
        {
            string l1 = "jorge";
            string l2 = "JORGE";
            l1 = l1.ToUpper();

            Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void ArreglosTest()
        {
            int[] l1 = { 1,2,3,4,5};
            int[] l2 = l1;
            Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void MatricesTest()
        {
            int[,] l1 = { {1, 2 }, { 3, 4 } };
            int[,] l2 = l1;
            Assert.AreEqual(l1, l2);
        }
    }

    public struct Vector3D
    {
        public float x;
        public float y;
        public float z;
    }

    public enum Idioma {
        NONE, ENG, ESP, JPN, ALM, CHN
    }
}
