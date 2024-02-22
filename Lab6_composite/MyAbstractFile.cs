using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_composite
{
    internal abstract class MyAbstractFile
    {
        protected string _name;

        public MyAbstractFile() {  }

        public MyAbstractFile(string name) {  _name = name; }

        public string Name { get { return _name; } set { _name = value; } }

        public abstract void List();
    }
}
