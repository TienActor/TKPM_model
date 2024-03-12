using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Iterator
{
    public class Section  :IEnumerable
    {
        private Student[] _students;

        public Section()
        {
            _students = new Student[5];
        }

        public void AddStudent(Student student)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                {
                    _students[i] = student;
                    return;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public StudentEnum GetEnumerator()
        {
            return new StudentEnum(_students);
        }
    }
}
