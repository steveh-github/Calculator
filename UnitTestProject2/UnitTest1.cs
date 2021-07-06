using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubtractionCalculation()
        {
            // Arrange
            double firstNumber = 75;
            double secondNumber = 25;
            double expected = firstNumber-secondNumber;
            double res;

            // Act
            Calculator.CalcSubtract calc = new Calculator.CalcSubtract(firstNumber, secondNumber);
            
            // Assert
            res = calc.CalculateExpression();

            Assert.AreEqual(expected, res, 0, "Error in SubtractionCalculation");
        }
    }
}
