using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition_Test()
        {
            //Arrange
            double firstNumber = 5;
            double secondNmber = 10;
            double expected = 15;

            Calculator.Calculator c = new Calculator.Calculator(firstNumber, secondNmber, '+');

            //Act
            double res = c.Calculate();

            //assert
            Assert.AreEqual(expected, res, 0, "Calculator Addition Wrong");
        }

        [TestMethod]
        public void Division_Test()
        {
            //Arrange
            double firstNumber = 100;
            double secondNmber = 25;
            double expected = 4;

            Calculator.Calculator c = new Calculator.Calculator(firstNumber, secondNmber, '/');

            //Act
            double res = c.Calculate();

            //assert
            Assert.AreEqual(expected, res, 0, "Calculator Division Wrong");
            
        }

        [TestMethod]
        public void UserInput_Test()
        {
            
            //Act & assert
            Assert.IsTrue(Calculator.Parse.InputIsValid("1+1"));
            Assert.IsTrue(Calculator.Parse.InputIsValid("    7    **    7.0  "));
            Assert.IsFalse(Calculator.Parse.InputIsValid("    7    *   H  "));


        }

    }
}
