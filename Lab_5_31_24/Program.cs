using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_31_24
{
    internal class Program
    {
        static void BaseCase()
        {
            // file cấu hình
            int[] monster_map = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };


            foreach(int monster in monster_map)
            {
                Monster m;
                if(monster == 1)
                {
                    m = new Mosquito();
                }    
                else if(monster == 2)
                {
                    m=new Wolf();
                }    
                else
                {
                    m =new Skeleton();
                }    
                Console.WriteLine(m);
            }    
        }

        public void RandomFactory()
        {
            // file cấu hình
            int[] monster_map = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            foreach (int monster in monster_map)
            {
                Monster m = RandomFactory.Create(monster);
                Console.WriteLine(m);
            }
        }

        static void Main(string[] args)
        {
            BaseCase();
        }
    }
}
