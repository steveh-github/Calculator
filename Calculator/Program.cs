using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {

               // prompt user for the equation
               string userInput = UserIO.GetInput();

               // break the loop if they typed Exit 
               if (userInput.ToLower() == "exit")
                {
                  break;
                }

               // inform user and then 
               // skip remaing code in loop if the input was bad
                if (!Parse.InputIsValid(userInput))
                {
                    UserIO.ShowBadInputMessage();
                    continue;
                }

                // now do the calculation
                double firstNumber = Parse.GetFirstNumber(userInput);
                double secondNumber = Parse.GetSecondNumber(userInput);
                char op = Parse.GetOperand(userInput);
                
                Calc calc;
                double res = 0;

                switch (op)
                {
                    case '+':
                        calc = new CalcAdd(firstNumber, secondNumber);
                        res = calc.CalculateExpression();
                        break;
                    case '-':
                        calc = new CalcSubtract(firstNumber, secondNumber);
                        res = calc.CalculateExpression();
                        break;
                    case '*':
                        calc = new CalcMultiply(firstNumber, secondNumber);
                        res = calc.CalculateExpression();
                        break;
                    case '/':
                        calc = new CalcDivide(firstNumber, secondNumber);
                        res = calc.CalculateExpression();
                        break;
                }

                UserIO.ShowResult(res);
                               
            }

        }
    }
}
