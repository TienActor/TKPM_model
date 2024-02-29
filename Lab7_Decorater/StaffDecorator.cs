using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Decorater
{
    internal class StaffDecorator : IStaff
    {
        private IStaff _staff;

        public StaffDecorator(IStaff staff)
        {
            _staff = staff;
        }

        public double GetSalary(int sales)
        {
            double salary = _staff.GetSalary(sales);

            if (salary <= 15_000_000)
            {
                return salary - (salary * 0.1); // - 10% 
            }
            else
            {
                return salary - (salary * 0.2); // - 20% 
            }
        }

    }
}
