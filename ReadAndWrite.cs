using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class ReadAndWrite
    {
        string productName = "chocolate eclair icecream bars";
        int totalStock = 64;
        double price = 6.789;
            
        internal void Test()
        {
            // concatenation method 1
            Console.WriteLine("we are selling " + productName + "!");

            // concatenation method 2
            Console.WriteLine($"{productName} cost ${price}");

            // concatentaion & formatting
            Console.WriteLine("there are {0} {1} in stock, each selling for {2:c}", totalStock, productName, price);

            // concatenatin w/ math
            Console.WriteLine($"if you want to buy the entire stock of {productName}, it would be %{totalStock * price}!");

            // do they want to buy it?
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("purhase? (y/n): ");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer != "")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;
                answer = answer.Substring(0, 1);
                if (answer == "y")
                {
                    Console.WriteLine("order placed!");

                }
                else if (answer == "n")
                {
                    Console.WriteLine("order cancelled");
                }
                else
                {
                    Console.WriteLine("error: uncognized input");
                }
            }
            else
            {
                Console.WriteLine("error: uncognized input");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
            
    }
}
