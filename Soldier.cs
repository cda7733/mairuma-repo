using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCode
{
    internal class Soldier
    {
        string name;
        internal string Name
        {
            get { return name; }
            set { name = value; }

        }
        string weapon;
        internal string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        internal string age;
        internal string Age
        {
            get { return age; }
            set { age = value; }
        }

        internal Soldier()
        {

        }
    }
}
