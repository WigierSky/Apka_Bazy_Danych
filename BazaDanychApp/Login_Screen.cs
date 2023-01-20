using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BazaDanychApp
{
    public partial class Login_Screen : Form
    {
        //string connetionString;
       // SqlConnection cnn;

        //przykładowy connection string
        //public static string connetionString = @"Data Source=DESKTOP-T5M32D0;Initial Catalog=wypozyczalnia_plyt_winylowych;Integrated Security=true";
        //public bool isAdmin = false;
       
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            MessageBox.Show("Połączono z bazą danych!");
            Global.cnn.Close();

            // Set to no text.
            Pass_Box.Text = "";
            // The password character is an asterisk.
            Pass_Box.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            Pass_Box.MaxLength = 5;

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Login_Box.Clear();
            Pass_Box.Clear();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Log_Click(object sender, EventArgs e)
        {
            if(Login_Box.Text == "Worker" && Pass_Box.Text == "Pass")
            {
                new Loan_Panel().Show();
                this.Hide();
                Global.isAdmin = false;
            }
            else if (Login_Box.Text == "" && Pass_Box.Text == "")
            {
                new Admin_Panel().Show();
                this.Hide();
                Global.isAdmin = true;
            }
            else
            {
                MessageBox.Show("Login lub Hasło nieprawidłowe!");
                Login_Box.Clear();
                Pass_Box.Clear();
                Login_Box.Focus();
            }
        }
    }
}
