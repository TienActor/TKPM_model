using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Lab8_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Section math1021 = new Section();
            math1021.AddStudent(new Student("110005", "Hoa"));
            math1021.AddStudent(new Student("110006", "Yen"));
            math1021.AddStudent(new Student("110007", "Minh"));
            math1021.AddStudent(new Student("110008", "Miint"));
            math1021.AddStudent(new Student("110009", "Mon"));
            foreach (Student student in math1021)
            {
                Console.WriteLine(student);
            }

           
        }
    }
}
