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
            //User user = new User("Administrator", UserRole.Admin);
            User user = new User("Guest", UserRole.Reader);
            //User user = new User("Administrator", UserRole.Author);
            Blog blogService = new Blog(); // Tạo một instance của Blog
            ProtectionProxy blogProxy = new ProtectionProxy(user,blogService);
            
            blogProxy.Create();
            blogProxy.View(26);
            Console.ReadKey();
        }
    }
}
