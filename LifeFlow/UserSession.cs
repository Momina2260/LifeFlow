using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeFlow
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Role { get; set; }
        public static string Email { get; set; }
    }
}
