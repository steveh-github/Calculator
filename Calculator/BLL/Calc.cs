using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BLL
{
    public class Calc : ICAL
    {
        public double number1 { get; set ; }
        public double number2 { get; set ; }

        public Calc(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public double Add()
        {
            return number1 + number2;
        }

        public double Divide()
        {
            return number1 / number2;
        }

        public double Multiply()
        {
            return number1 * number2;
        }

        public double Subtract()
        {
            return number1 - number2;
        }
    }
}
