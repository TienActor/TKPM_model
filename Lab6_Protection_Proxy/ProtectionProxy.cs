using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Protection_Proxy
{

    // Định nghĩa UserRole, đảm bảo rằng có một giá trị UserRole.Reader nếu bạn muốn sử dụng cho người dùng thông thường.
    public enum UserRole
    {
        User,
        Admin
    }

    public class ProtectionProxy : IService
    {
        //private readonly IService _service;
        private readonly User user;
        private readonly Blog service;


        public ProtectionProxy(User user, Blog service)
        {
            this.user = user;
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public void View(int objID)
        {
            // All users can view blog posts
            service.View(objID);
        }
        public void Create()
        {
            // Only users with Author or Admin role can create blog posts
            if ( user.Role == UserRole.Admin)
            {
                service.Create();
            }
            else
            {
                Console.WriteLine("Unauthorized access. Only authors and admins can create blog posts.");
            }
        }
    }
}
