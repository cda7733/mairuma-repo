using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class Lunch
    {
        internal string Lunches(string lunchOrder)
        {
            switch (lunchOrder.ToLower())
            {
                case "sandwich":
                    Console.WriteLine("what kind of sandwhich do you want?\n1. peanut butter sandwich\n2. peanut butter and jelly\n3. tuna\n4. surprise me!");
                    // call method to check if valid answer (is null or empty)
                    string sandwichType = Console.ReadLine().Trim().ToLower();
                    switch (sandwichType)
                    {
                        case "1": // peanut butter
                        case "2": // peanut butter AND jelly
                        case "3": // tuna
                        case "4": // surprise me
                            Console.WriteLine("making your sandwich now..");
                            break;
                        default:
                            Console.WriteLine("that type of sandwich isn't on the menu");
                            break;
                    }
                    break;
                case "tacos":
                case "fries":
                case "taquito":
                case "horchata":
                case "ice cream":
                    Console.WriteLine("coming right up!");
                    break;
                default:
                    Console.WriteLine("that isn't on the menu!");
                    break;
            }
            return lunchOrder;
        }
        // sandwchis, tacos, fires, soup, taquito, ice cream
    }
}
