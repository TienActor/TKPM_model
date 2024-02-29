using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Decorater
{
    internal class Staff : IStaff
    {
        private string _name;
        private double _salary;
        public Staff() { }
        public Staff(string name)
        {
            _name = name;
            _salary = 6_000_000;
        }

        public override string ToString()
        {
            return _name;
        }
        public double GetSalary(int sales)
        {
            return _salary + (sales * 100_000);
        }
    }
}
