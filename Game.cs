using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal abstract class Game
    {
        internal abstract void DisplayInfo();
        internal void RollDie()
        {
            Console.WriteLine("rolling a number between 1 and 6");
        }
        internal void RollDie(int min, int max)
        {
            Console.WriteLine($"rolling a number between {min} and {max-1}");
        }
        internal Game()
        {
            string name;
        }   
        internal abstract class Board : Game
        {
            int spaceNumber = 1;
            internal override void DisplayInfo()
            {
                Console.WriteLine("you are on space number " + spaceNumber);
            }
        }
        internal abstract class Card : Game
        {
            string cardText = "nothing";
            internal override void DisplayInfo()
            {
                Console.WriteLine("this card says " + cardText);
            }
        }
    }
}
