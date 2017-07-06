using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private metodos sut ;

        [TestInitialize]
        public void UnitTestProject()
        {
            sut = new metodos();
        }

        [TestMethod]
        public void TestMethod1()
        {
            String texto = sut.mensaje();
            Assert.AreSame("Los datos son: nuevo texto 1 2",texto);

        }
    }
}
