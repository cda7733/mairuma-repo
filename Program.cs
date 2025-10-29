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
            /*
            List<string> myAnimals = new List<string>();
            myAnimals.AddRange(new string[] { "mouse", "rat", "bat", "dove", "tiger" });
            myAnimals.Insert(2, "fox");
            myAnimals.Remove(myAnimals[5]);

            foreach (string myAnimal in myAnimals) { Console.WriteLine(myAnimal); }
            Console.WriteLine("capacity: " + myAnimals.Capacity);
            Console.WriteLine("count: " + myAnimals.Count);
            
            List<Animals> myAnimals = new List<Animals>(4);
            myAnimals.AddRange(new Animals[] { new Animals(), new Animals(), new Animals(), new Animals(), new Animals()});

            Dictionary<string, string> fanNames = new Dictionary<string, string>()
            {
                {"rosco", "roscals"}, {"lucien","lunarists"}, {"elias","delsters"}, {"ashkariel","marimomies"}, {"cassian","dewdrops"}
            };
            */

            Dictionary<string, ConsoleColor> identifyingColor = new Dictionary<string, ConsoleColor>();
            identifyingColor.Add("rosco", ConsoleColor.Magenta);
            identifyingColor.Add("lucien", ConsoleColor.DarkRed);
            identifyingColor.Add("elias", ConsoleColor.Cyan);
            identifyingColor.Add("ashkariel", ConsoleColor.Yellow);
            identifyingColor.Add("cassian", ConsoleColor.Green);

            Dictionary<string, Mascot> fans = new Dictionary<string, Mascot>()
            {
                {"rosco", new Mascot("roscals","mice")},
                {"lucien", new Mascot("lunarists","cultists")},
                {"elias", new Mascot("delsters","lab-rats")},
                {"ashkariel", new Mascot("marimomies","marimos")},
                {"cassian", new Mascot("dewdrops","dewdrops")},
            };

            foreach (KeyValuePair<string,Mascot> fan in fans)
            {
                Console.ForegroundColor = identifyingColor[fan.Key];
                Console.WriteLine($"{fan.Key} calls his fans {fans[fan.Key].name} \nthey are {fans[fan.Key].thing}\n");
            }
            Console.ResetColor();
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
            

            soldier code
            Soldier soldier1 = new Soldier();
            Console.Write("enter soldier's name: ");
            soldier1.Name = Console.ReadLine();
            Console.Write("enter soldier's weapon: ");
            soldier1.Weapon = Console.ReadLine();
            Console.Write("enter soldier's age: ");
            soldier1.Age = Console.ReadLine();
            

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
            int x = 5;
            x = ++x;
            int y = 5;
            y = y++;
            Console.WriteLine("x: " + x + "\ny: " + y);
            */
        }
    }
}
