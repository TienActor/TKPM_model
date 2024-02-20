using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon1
{
    public class Singleton
    {
        private Singleton instance;
        private String dvd;
        private String music;

        private Singleton() { }

        public static Singleton getInstance(Singleton instance)
        { 
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance; }

    }
}
