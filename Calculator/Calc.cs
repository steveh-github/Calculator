using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Calc
    {
        public double firstNumber { set; get; }
        public double secondNumber { set; get; }
        public abstract double CalculateExpression();

    }
}
