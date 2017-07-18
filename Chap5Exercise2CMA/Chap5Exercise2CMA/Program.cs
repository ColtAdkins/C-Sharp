using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Adds numbers and uses 999 as an exit code.
*   Written by Colton Adkins
*/
namespace Chap5Exercise2CMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            const int EXIT = 999;
            List<int> numbersInput = new List<int>();
            Console.WriteLine("*** Addition of Integer Numbers ***");
            Console.Write("\n");
            Console.WriteLine("To stop the program, enter the value 999");
            Console.Write("Enter an integer number: ");
            input = Console.Read();
            while (input != EXIT)
            {
                Console.Write("Enter an integer number: ");
                input = Console.Read();
            }
            Console.Write("\n");
            Console.WriteLine("The sum of the numbers is: ");
            Console.WriteLine("The number count is: ");
            Console.Write("\n");
            Console.Write("Press the <Enter> key to terminate this program.");
            Console.Read();
        }
    }
}
