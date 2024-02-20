using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_31_24
{
    internal class RandomFactory : Monster
    {


        public void CreatsMonster()
        {
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                Monster m;
                int ri = r.Next(0, 3);
                if(ri == 0)
                {
                    m = new Mosquito();
                }    
                else if(ri<10)
                {
                    m=new Wolf();
                }
                else
                {
                    m=new Skeleton();
                }
                Console.WriteLine(m);
                    
            }    
        }
    }
}
