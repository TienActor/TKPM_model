using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Protection_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Administrator", UserRole.Admin);
            //User user = new User("Nguoi dung 1", UserRole.User);
            ProtectionProxy blogProxy = new ProtectionProxy(user);
            blogProxy.Create();
            blogProxy.View(26);
            Console.ReadKey();
        }
    }
}
