using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Monster
{
    internal static class RandomFactory
    {
        public static Monster Create(int monsterType)
        {
            switch (monsterType)
            {
                case 1:
                    return new Mosquito();
                case 2:
                    return new Wolf();
                case 3:
                    return new Skeleton();
                default:
                    throw new ArgumentException("Invalid monster type");
            }
        }
    }
}
