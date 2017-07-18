// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must re-enter the number
// The program displays the correct price
using System;
namespace DebugFive2
{
    public class DebugFive2
    {
        public static void Main()
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99;
            const double PRICE312 = 16.77;
            const double PRICE414 = 109.07;
            Console.WriteLine("Please enter the stock number of the item you want ");
            string stockNum;
            for (stockNum = Console.ReadLine(); stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414; stockNum = Console.ReadLine())
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
            }
            double price;
            if (stockNum == ITEM209)
            {
                price = PRICE209;

            }
            else if (stockNum == ITEM312)
            {

                price = PRICE312;
            }
            else
            {
                price = PRICE414;

            }
            Console.Write("The price for item # {0} is {1}", stockNum, price.ToString("C"));
            Console.WriteLine("\nPress the <Enter> key to terminate the program.");
            Console.Read();
        }
    }
}