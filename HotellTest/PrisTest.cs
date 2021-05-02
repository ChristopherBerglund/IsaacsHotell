using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsaacsHotell.Controllers;
using System.Collections.Generic;
using IsaacsHotell.Models;
using IsaacsHotell.Method;

namespace HotellTest
{
    [TestClass]
    public class PrisTest
    {
        [TestMethod]
        [Description("Test för tomlista")]
        public void NoOrdersInList()
        {
            //Arrange
            var Ordrar = new List<Order>();
            var expected = 0;
            
            //Act
            var totalpris = TotalPris.Summera(Ordrar);

            //Assert
            var actual = totalpris;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Testar if statement ")]
        public void NegativeNumbers() 
        {

            //Arrange
            var lista = new List<Order> { 
                new Order { Pris = -50 }};
            var expected = -1;
            //Act

            var actual = TotalPris.Summera(lista);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Testar foreach:en statement ")]
        public void ForeachTestReturnOnThird()
        {

            //Arrange
            var lista = new List<Order> {
                new Order { Pris = 600 },
                new Order { Pris = 600 },
                new Order { Pris = -50 }};
            var expected = -1;
            //Act

            var actual = TotalPris.Summera(lista);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
