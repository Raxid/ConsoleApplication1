using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace ConsoleApplication.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmptyStringShouldReturnZero()
        {
            var calculator = new Adder();

            var result = calculator.Add("");

            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void GivenOneNumberShouldReturnThatNumber(){
            var calculator = new Adder();

            var result = calculator.Add("1");

            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void GivenTwoNumbersShouldReturnSumOfThem()
        {
            var calculator = new Adder();

            var result = calculator.Add("2,1");

            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void NewlineShouldBeAValidDelimiter()
        {
            var calculator = new Adder();
            var input = "1\n2";

            var result = calculator.Add(input);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void ShouldReturnSumOfMoreNumbers()
        {
            var calculator = new Adder();
            var input = "1,2,3,4,5";

            var result = calculator.Add(input);

            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void ShouldReturnSumWithMoreComplicateStream()
        {
            var calculator = new Adder();
            var input = "1\n2,3";
            var result = calculator.Add(input);
            Assert.AreEqual(6, result);
        }

    }
}
