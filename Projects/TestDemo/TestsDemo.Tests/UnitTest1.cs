using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo1;

namespace TestsDemo.Tests
{
    [TestClass]//atributos, acrescentando metadados adicional
    public class UnitTest1
    {
        [TestMethod]
        public void Adiciona2_e_2_retorna_4()
        {
            // Arrange
            var calc = new Calculadora();

            // Act
            int expect = 4;
            int actual = calc.Adicionar(2, 2);

            // Assert
            Assert.AreEqual(expect, actual);
            
        }
    }
}
