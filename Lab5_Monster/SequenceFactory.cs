using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Monster
{
    internal class SequenceFactory : IMonsterFactory
    {
        private int _currentIndex = 0;
        private Func<Monster>[] _monsterSequence;

        public SequenceFactory()
        {
            // Initialize the sequence of monster creation functions
            _monsterSequence = new Func<Monster>[]
            {
                () => new Mosquito(),
                () => new Wolf(),
                () => new Skeleton()
            };
        }

        public Monster CreateMonster()
        {
            // Create monster based on the current index in the sequence
            Monster monster = _monsterSequence[_currentIndex]();
            // Cycle through the sequence
            _currentIndex = (_currentIndex + 1) % _monsterSequence.Length;
            return monster;
        }
    }
}
