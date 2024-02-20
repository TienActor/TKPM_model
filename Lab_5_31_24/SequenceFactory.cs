using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_31_24
{
    internal class SequenceFactory : IMonsterFactory
    {
        

        public void CreatMonster()
        {
            for (int i = 0; i < 15; i++)
            {
                Monster m;
                if (i < 5)
                {
                    m = new Mosquito();
                }
                else if (i < 10)
                {
                    m = new Wolf();
                }
                else
                {
                    m= new Skeleton();
                }
                Console.WriteLine(m);
            }
        }
    }
}
