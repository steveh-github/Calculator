using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SubtractionCalculation()
        {
            // Arrange
            double firstNumber = 7.5;
            double secondNumber = 3.5;
            double expected = firstNumber-secondNumber;
            double res;

            // Act
            Calculator.BLL.Calc calc = new Calculator.BLL.Calc(firstNumber, secondNumber);

            // Assert
            res = calc.Subtract();

            Assert.AreEqual(expected, res, 0, "Error in SubtractionCalculation");
        }

        [TestMethod]
        public void AdditionCalculation()
        {
            // Arrange
            double firstNumber = 7.5;
            double secondNumber = 3.5;
            double expected = firstNumber + secondNumber;
            double res;

            // Act
            Calculator.BLL.Calc calc = new Calculator.BLL.Calc(firstNumber, secondNumber);

            // Assert
            res = calc.Add();

            Assert.AreEqual(expected, res, 0, "Error in AdditionCalculation");
        }

        [TestMethod]
        public void MultiplicationCalculation()
        {
            // Arrange
            double firstNumber = 7.5;
            double secondNumber = 3.5;
            double expected = firstNumber * secondNumber;
            double res;

            // Act
            Calculator.BLL.Calc calc = new Calculator.BLL.Calc(firstNumber, secondNumber);

            // Assert
            res = calc.Multiply();

            Assert.AreEqual(expected, res, 0, "Error in MultiplicationCalculation");
        }

        [TestMethod]
        public void DivisionCalculation()
        {
            // Arrange
            double firstNumber = 7.5;
            double secondNumber = 3.5;
            double expected = firstNumber / secondNumber;
            double res;

            // Act
            Calculator.BLL.Calc calc = new Calculator.BLL.Calc(firstNumber, secondNumber);

            // Assert
            res = calc.Divide();

            Assert.AreEqual(expected, res, 0, "Error in DivisionCalculation");
        }

        [TestMethod]
        public void GoodInput()
        {
            // Arrange and Act
            bool res = Calculator.Parse.InputIsValid("7.5 + 3.5");

            // Assert
            Assert.AreEqual(true, res, "Error in Good Input Validation");
        }

        [TestMethod]
        public void BadInput()
        {
            // Arrange and Act
            bool res = Calculator.Parse.InputIsValid("7.5 ++ 3.5");

            // Assert
            Assert.AreEqual(false, res, "Error in Bad Input Validation");
        }

    }

}
