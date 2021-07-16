using Calculator.BLL;
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

                double res = 0;

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
               
                CalculatorBLL myCal = new CalculatorBLL(firstNumber, secondNumber);

                switch (Parse.GetOperand(userInput))
                {
                    case Parse.calculation.Add:
                        res = myCal.Add();
                        break;
                    case Parse.calculation.Subtract:
                        res = myCal.Subtract();
                        break;
                    case Parse.calculation.Multiply:
                        res = myCal.Multiply();
                        break;
                    case Parse.calculation.Divide:
                        res = myCal.Divide();
                        break;
                }

                UserIO.ShowResult(res);
                               
            }

        }
    }
}
