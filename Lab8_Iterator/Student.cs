using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Iterator
{
    public class Student
    {
        public String Id { get; set; }
        public String Name { get; set; }

        public Student() { }

        public Student(String id, String name)
        {
            Id = id;
            Name = name;
        }



        public override String ToString()
        {
            return $"Student Id :{Id}, Name:{Name}";
        }
    }
}
