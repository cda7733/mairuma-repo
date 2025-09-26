using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class Utility
    {
        internal string dataCombo;
        // have a method that calls oc methods and returns all th values as a singl string, split by |||
        internal static void Welcome()
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"welcome to demon school, {name}-kun!\n");
        }
        internal static void Welcome(string name)
        {
            Console.WriteLine($"welcome back to demon school, {name}-kun!\n");
        }


        
        internal static string GameName(string thing)
        {
            int playerIndex = 1;
            Console.WriteLine($"what {thing} do you want?");
            string chosenThing = Console.ReadLine().Trim();
            string combo =  chosenThing + "," + playerIndex;
            return combo;
        }
        internal static string[] Split(string input)
        {
            char splitCharacter = ',';

            string[] playerData = input.Split(splitCharacter);
            return playerData;
        }
    }
}
