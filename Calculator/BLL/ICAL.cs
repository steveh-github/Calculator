using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BLL
{
    interface ICAL
    {
        double number1 { get; set; }
        double number2 { get; set; }

        double Add();
        double Subtract();
        double Divide();
        double Multiply();

    }
}
