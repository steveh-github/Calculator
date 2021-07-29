using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Parse
    {
        public enum calculation
        {
            Add,
            Subtract,
            Divide,
            Multiply
        }

        public static double GetFirstNumber(string userInput)
        {
            string parse = userInput.Replace(" ", "");
            string[] data = parse.Split('+', '-', '*', '/');
            return Convert.ToDouble(data[0]);
            
        }

        public static double GetSecondNumber(string userInput)
        {
            string parse = userInput.Replace(" ", "");
            string[] data = parse.Split('+', '-', '*', '/');
            return Convert.ToDouble(data[1]);

        }

        public static calculation GetOperand(string userInput)
        {

   
            if (userInput.Contains("+"))
            {
                return calculation.Add;
            }
            else if (userInput.Contains("-"))
            {
                return calculation.Subtract;
            }
            else if (userInput.Contains("*"))
            {
                return calculation.Multiply;

            }else if (userInput.Contains("/"))
            {
                return calculation.Divide;
            }
            else
            {
                throw new NotImplementedException("Not Implemented");
            }
        }




        public static bool InputIsValid(string userInput)
        {

            //The string must have 2 numbers and an operand 
            //parse it to check

            string parse = userInput.Replace(" ", "");
            string[] data = parse.Split('+', '-', '*', '/');
            double n1;
            double n2;
            bool isValid;

            if (data.Length !=2)
            {
                //Failed straight away!
                return false;
            }
            else
            {
       
                //now check we have 2 numbers

                isValid = Double.TryParse(data[0], out n1);

                if (isValid)
                {
                    isValid = Double.TryParse(data[1], out n2);
                }

                return isValid;
            }



        }

    }
}
