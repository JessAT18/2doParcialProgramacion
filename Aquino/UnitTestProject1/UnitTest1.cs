using System;
using Jessica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSave5000Plus1000EqualTo6000()
        {
            //Organizar
            Person person = new Person("Jessica Aquino", 5000);
            double valoresperado = 6000;
            //Actuar
            person.Save(1000);
            double valorobtenido = person.SaveMoney;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
        [TestMethod]
        public void TestSpend6000Minus1000EqualTo5000()
        {
            //Organizar
            Person person = new Person("Andrea Torrez", 6000);
            double valoresperado = 5000;
            //Actuar
            person.Spend(1000);
            double valorobtenido = person.SaveMoney;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
        [TestMethod]
        public void TestChangeNameFromJuanToDiego()
        {
            //Organizar
            Person person = new Person("Juan Sanchez", 2000);
            string valoresperado = "Diego Fernandez";
            //Actuar
            person.ChangeName("Diego Fernandez");
            string valorobtenido = person.Name;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
    }
}
