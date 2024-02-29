using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Monster
{
    internal class RandomFactory : IMonsterFactory
    {
        private static Random _random = new Random();

        // Implement the interface method to create a Monster
        public Monster CreateMonster()
        {
            int monsterType = _random.Next(1, 4); // Generates a number between 1 and 3
            return Create(monsterType); // Calls the private method to create a specific Monster
        }

        // Private method to create a Monster based on a given type
        private static Monster Create(int monsterType)
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
