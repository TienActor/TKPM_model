using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Protection_Proxy
{
    public class Blog : IService
    {
        public void Create()
        {
            // Logic to view a blog post
            Console.WriteLine("Creating a new blog post");
            //throw new NotImplementedException();
        }

        public void View(int objId)
        {
            // Logic to create a new blog post
            Console.WriteLine($"Viewing blog at post {objId}");
           // throw new NotImplementedException();
        }
    }
}
