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
            var result = Calculator.Add("");
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void OneElementTest(){
            var result = Calculator.Add("1");
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void SimpleDataTest()
        {
            var result = Calculator.Add("2,1");
            Assert.AreEqual(result, 3);
        }
    }
}
