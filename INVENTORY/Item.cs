using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY
{
    public abstract class Item
    {
        public int PosX;
        public int PosY;
        public string Name;
        public int ItemLevel;
        public string Text;
        
        public int LevelForUse()
        {

            return ItemLevel;
        }


        protected Item(int PosX, int PosY, string Name, int ItemLevel, string Text)
        {

        }
    }

      
}
