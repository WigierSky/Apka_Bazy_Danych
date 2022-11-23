using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
