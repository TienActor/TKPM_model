using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Singleton firstInstance = Singleton.GetInstance();
            Singleton secondInstance = Singleton.GetInstance();

            Console.WriteLine("HashCode of firstInstance: " + firstInstance.GetHashCode());
            Console.WriteLine("HashCode of secondInstance: " + secondInstance.GetHashCode());

            if (firstInstance.GetHashCode() == secondInstance.GetHashCode())
            {
                Console.WriteLine("The instances are the same.");
            }
            else
            {
                Console.WriteLine("The instances are different.");
            }


            Console.ReadKey();
        }
    }
}
