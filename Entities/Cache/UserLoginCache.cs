using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string CompanyName { get; set; }
        public static string FirstName { get; set;}
        public static string LastName { get; set;}
        public static bool Admin { get; set;}
        public static string Email { get; set;}
    }
}
