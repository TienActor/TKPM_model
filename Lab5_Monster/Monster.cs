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
            return $"{this.GetType().Name} , HP:{_hp} , Armor:{_armor}, Speed:{_speed}";

        }
    }
}
