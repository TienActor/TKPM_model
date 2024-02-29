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
                Monster m = SimpleMonsterFactory.Create(monster);
                Console.WriteLine(m);
            }
        }


        public static void RandomMonster() {
            Random ran = new Random();
            for (int i = 0; i < 10; i++) // Tạo 10 monster ngẫu nhiên
            {
                int monsterType = ran.Next(1, 4); // Tạo một số ngẫu nhiên từ 1 đến 3
                Monster m = SimpleMonsterFactory.Create(monsterType);
                Console.WriteLine(m);
            }
        }

        public static void SimpleMonster()
        {
            Random ran = new Random();
            for (int i = 0; i < 10; i++) // Tạo 10 monster ngẫu nhiên
            {
                int monsterType = ran.Next(1, 4); // Tạo một số ngẫu nhiên từ 1 đến 3
                Monster m = SimpleMonsterFactory.Create(monsterType);
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /// Câu 2
            Console.WriteLine("\n Đây là các monster được lên list sẵn :");
            BaseCase();
            Console.ReadKey();


            /// Câu 3
            Console.WriteLine("\n Đây là code chạy bằng simple factory các quái vật :");
            SimpleMonster();
            Console.ReadKey();



            /// Câu 4
            /// 
            Console.WriteLine("\nKết quả bài 4: \n");
            Console.WriteLine("Chọn chế độ (E - Easy, H - Hard): ");
            string input = Console.ReadLine();
            string mode;

            if (input.Equals("H", StringComparison.OrdinalIgnoreCase))
            {
                mode = "Hard";
            }
            else
            {
                mode = "Easy";
            }
            IMonsterFactory factory;

            if (mode.Equals("Hard", StringComparison.OrdinalIgnoreCase))
            {
                factory = new RandomFactory();
            }
            else // Easy mode
            {
                factory = new SequenceFactory();
            }

            for (int i = 0; i < 15; i++)
            {
                Monster monster = factory.CreateMonster();
                Console.WriteLine(monster.ToString());
            }
            Console.ReadKey();
        }
    }
}
