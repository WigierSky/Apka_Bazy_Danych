using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BazaDanychApp.Login_Screen;

namespace BazaDanychApp
{
    public static class Global
    {
        public static bool isAdmin = false;
        public static string connetionString;
        public static SqlConnection cnn = new SqlConnection(connetionString);

        static string conectString()
        {
            if (isAdmin == false)
            {
                return connetionString = @"Data Source=DESKTOP-T5M32D0;Initial Catalog=wypozyczalnia_plyt_winylowych;Integrated Security=true";
            }
            else
            {
                return connetionString = @"Data Source=DESKTOP-T5M32D0;Initial Catalog=wypozyczalnia_plyt_winylowych;Integrated Security=true";
            }
        }

    }
}
