using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Iterator
{
    public class StudentEnum :IEnumerator
    {
        public Student[] students;

        // enumraiton position

        int position = -1;

        public StudentEnum(Student[] list)
        {
            students = list;
        }

        public bool MoveNext()
        {
            position++;
            return position < students.Length;
        }

        public void Reset()
        {
            position = -1;
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return students[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
