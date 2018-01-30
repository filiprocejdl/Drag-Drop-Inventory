using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY
{
    class Lektvar : Item
    {
        public int HealorDmg;
        public int TimeLimit;

        public int IsItHealOrPoison()
        {

            return HealorDmg;
        }

        public Lektvar(int PosX, int PosY, string Name, int ItemLevel, string Text) : base(PosX, PosY, Name, ItemLevel, Text) { }

    }
}
    