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

namespace BazaDanychApp
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connetionString;
            //SqlConnection cnn;

            ////przykładowy connection string
            //connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";

            //cnn = new SqlConnection(connetionString);

            //cnn.Open();
            //MessageBox.Show("Połączono z bazą danych!");

            //cnn.Close();
         
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
            if(Login_Box.Text == "Login" && Pass_Box.Text == "Pass")
            {
                new Admin_Panel().Show();
                this.Hide();
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
