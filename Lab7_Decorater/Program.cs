using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Decorater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Staff s = new Staff("Tiền lương của Tiến: ");
            Console.WriteLine(s);
            Console.WriteLine(s.GetSalary(1));
            Console.WriteLine("\n---------- \n ");


            Console.Write("Sau khi trừ thuế: \n");
            StaffDecorator staffDec = new StaffDecorator(s);
            Console.WriteLine(staffDec.GetSalary(1));
            Console.ReadKey();
        }
    }
}
