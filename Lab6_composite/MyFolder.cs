using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_composite
{
    internal class MyFolder : MyAbstractFile
    {
        protected LinkedList<MyAbstractFile> _files;
        public MyFolder() { }

        public MyFolder(string name) : base(name)
        {
            _files = new LinkedList<MyAbstractFile>();
        }

        public void Add(MyAbstractFile obj)
        {
            _files.AddLast(obj);
        }

        public void Remove(MyAbstractFile obj)
        {
            _files.Remove(obj);
        }


        public override void List()
        {
            Console.WriteLine($"{Name}");


            foreach (MyAbstractFile child in _files)
            {
                if (child.GetType() == typeof(MyAbstractFile))
                {
                    Console.WriteLine($"\t {child.Name}");
                }
                else
                {
                    Console.WriteLine($"\t {child.Name}");
                }
            }

            //throw new NotImplementedException();
        }
    }
}
