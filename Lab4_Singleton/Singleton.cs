using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton
{
    public  class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        // Constructor is 'protected' to prevent creation via the 'new' operator
        protected Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
