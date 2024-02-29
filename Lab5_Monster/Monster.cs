using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Monster
{
    internal abstract class Monster
    {
        protected int _hp;
        protected int _armor;
        protected int _speed;

        public override string ToString()
        {
            return $"{this.GetType().Name,-15} | HP:{_hp,-5} | Armor:{_armor,-7} | Speed:{_speed,-6}";
        }
    }
}
