using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string creatorName = "charisma";
            Utility.Welcome();
            Utility.Welcome(creatorName);
            MairumaCharacter Kiriwo = new MairumaCharacter("kiriwo ami", true, 2, "teal");
            Kiriwo.Display();
            MairumaCharacter Iruma = new MairumaCharacter("iruma suzuki", "blue");
            Iruma.Display();
            */

            /* idea. simple oc maker vs advanced oc  maker. 
             * simple oc: name, demon?, hair color
             * advanced: name, demon?, hair color, num of horns, babylus status, power description, quote
             * 
             * check input for simple or advanced
             * if it is exact == send user the prompt they want
             * if it starts with an s or a, ask the user to verify
             * set all inputs to lower btw
             
            MairumaCharacter OC1 = new MairumaCharacter();
            OC1.
            OC1.Display();
            */

            /* soldier code
            Soldier soldier1 = new Soldier();
            Console.Write("enter soldier's name: ");
            soldier1.Name = Console.ReadLine();
            Console.Write("enter soldier's weapon: ");
            soldier1.Weapon = Console.ReadLine();
            Console.Write("enter soldier's age: ");
            soldier1.Age = Console.ReadLine();
            */

            Console.WriteLine("what is your favorite number?");
            string input = Console.ReadLine().Trim();
            try
            {
                int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
