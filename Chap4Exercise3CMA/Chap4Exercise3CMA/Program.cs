using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4Exercise3CMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int gpa;
            int testScore;
            Console.WriteLine("Enter the grade point average: ");
            gpa = Console.Read();
            Console.WriteLine("Enter the test score: ");
            testScore = Console.Read();
            Console.WriteLine("The student should be {0}");
            Console.Write("\n Please press the <Enter> key to terminate the program");
        }
    }
}
