using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_composite
{
    internal class MyFile:MyAbstractFile
    {
        public MyFile() { }

        public MyFile(string name): base(name) { }

        public override void List()
        {
            Console.WriteLine(Name);
            //throw new NotImplementedException();    
        }
    }
}
