using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_Monster
{
    internal class Program
    {

        static void BaseCase()
        {
            // file cấu hình
            int[] monster_map = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };


            foreach (int monster in monster_map)
            {
                Monster m;
                if (monster == 1)
                {
                    m = new Mosquito();
                }
                else if (monster == 2)
                {
                    m = new Wolf();
                }
                else
                {
                    m = new Skeleton();
                }
                Console.WriteLine(m);
            }
        }
        public static void RandomFactoryMethod()
        {
            int[] monster_map = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            foreach (int monster in monster_map)
            {
                Monster m = RandomFactory.Create(monster);
                Console.WriteLine(m);
            }
        }


        public static void RandomMonster() {
            Random ran = new Random();
            for (int i = 0; i < 10; i++) // Tạo 10 monster ngẫu nhiên
            {
                int monsterType = ran.Next(1, 4); // Tạo một số ngẫu nhiên từ 1 đến 3
                Monster m = RandomFactory.Create(monsterType);
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n Đây là các monster được lên list sẵn :");
            BaseCase();
            Console.WriteLine("\n Đây là code random các quái vật :");
            //RandomFactoryMethod();
            RandomMonster();

            Console.ReadKey();
        }
    }
}
