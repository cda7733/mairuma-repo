using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class MairumaCharacter
    {
        // characteristics of characters
        internal string name;
        internal bool isDemon;
        internal int numberOfHorns;
        internal string hairColor;
        // internal string powerDescription
        // internal string quote;
        // internal string babylusStatus; // student, professor, enemy, etc.

        // oc 
        internal MairumaCharacter()
        {
            name = NameAnOC();
            isDemon = OCSpecies();
        }

        //demons
        internal MairumaCharacter(string name, bool isDemon, int numberOfHorns,string hairColor)
        {
            this.name = name;
            this.isDemon = true;
            this.numberOfHorns = numberOfHorns;
            this.hairColor = hairColor;
        }
        //humans
        internal MairumaCharacter(string name, string hairColor)
        {
            this.name=name;
            this.isDemon = false;
            this.hairColor=hairColor;
        }

        internal void Display()
        {
            // show all data
            Console.WriteLine($"character name: {name}");
            if (isDemon == true )
            {
                Console.WriteLine("this character is a demon! they have " + numberOfHorns + " horns.");
            }
            else if (isDemon == false)
            {
                Console.WriteLine("this character is not a demon.");
            }
            else
            {
                {
                    Console.WriteLine("not applicable.");
                }
            }
                Console.WriteLine("{0}'s hair is {1} \n", name, hairColor);
        }
        internal static string NameAnOC()
        {
            Console.Write("what would you like to name your character? ");
            string OCname = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("your character's name is " + OCname);
            return OCname;
        }
        internal static bool OCSpecies()
        {
            bool isDemon = true;
            Console.Write("");
            string input = Console.ReadLine().Trim().ToLower();
            input = input.Substring(0, 1);
            if (input == "n")
            {
                isDemon = false;
            }
            else if (input != "y" && input != "n")
            {
                Console.WriteLine("invalid input! please try again.");
                OCSpecies();
            }
            return isDemon;
        }
        
    }
}
