using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace ConsoleApplication.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturningZeroTest()
        {           
            var result = Calculator.Add(" , ");
            Assert.AreEqual(result, 0);
        }
    }
}
