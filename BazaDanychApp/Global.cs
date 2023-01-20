using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace BazaDanychApp
{
    public static class Global
    {
        public static bool isAdmin = false;
        public static string connetionString = @"Data Source=DESKTOP-T5M32D0;Initial Catalog=wypozyczalnia_plyt_winylowych;Integrated Security=true";
        public static SqlConnection cnn = new SqlConnection(connetionString);
    }
}
