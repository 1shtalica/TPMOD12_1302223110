using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPMOD12_1302223110;

namespace UnitTestTPMod12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCariTandaBilangan_Negatif()
        {
            Form1 form = new Form1();
            string result = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void TestCariTandaBilangan_Positif()
        {
            Form1 form = new Form1();
            string result = form.CariTandaBilangan(5);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void TestCariTandaBilangan_Nol()
        {
            Form1 form = new Form1();
            string result = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }
    }
}
