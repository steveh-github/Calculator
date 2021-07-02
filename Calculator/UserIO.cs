using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserIO
    {

        
        public static void ShowBadInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, I could not understand the operation");
            Console.ResetColor();
        }

        public static string GetInput()
        {
            Console.ResetColor();
            Console.WriteLine("Enter the mathematical expression: ");
            return Console.ReadLine();

        }

        internal static void ShowResult(double res)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The result is {0}",res);
            Console.ResetColor();
        }
    }
}
