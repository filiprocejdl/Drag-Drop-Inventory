using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY
{
    class Zbran : Item
    {
        public int Dmg;
        public int CritChance;
        

        public string GetNme()
        {
            return Name;
        }

        public int GetCrit()
        {
            return CritChance;
        }

        public int GetDmg()
        {
            return Dmg;
        }

        public Zbran(int PosX, int PosY, string Name, int ItemLevel,string Text) : base(PosX, PosY, Name, ItemLevel, Text) { }
    }
}
