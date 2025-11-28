using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LifeFlow
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Role { get; set; }
        public static string Email { get; set; }
        public static void ClearSession()
        {
            UserId = 0;
            UserName = null;
            Role = null;
        }
    }
    
    }
