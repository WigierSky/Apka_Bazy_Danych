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
        List<string> list = new List<string>();
        List<string> list2 = new List<string>();

        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            MessageBox.Show("Połączono z bazą danych!");

            SqlCommand comm = new SqlCommand("SELECT pracownik_id, PIN from pracownik", Global.cnn);


            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(String.Format("{0}", reader[1]));
                    list2.Add(String.Format("{0}", reader[0]));
                }
            }

            Global.cnn.Close();

            // Set to no text.
            Pass_Box.Text = "";
            // The password character is an asterisk.
            Pass_Box.PasswordChar = '*';
            // The control will allow no more than 5 characters.
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
            if(Login_Box.Text == "Worker" && list.Contains(Pass_Box.Text))
            {
                int ind = list.IndexOf(Pass_Box.Text);
                Global.pracownik_id = Convert.ToInt32(list2.ElementAt(ind));
                Global.isAdmin = false;
                new WorkerLogin().Show();
                this.Hide();
                
            }
            else if (Login_Box.Text == "" && Pass_Box.Text == "")
            {
                Global.isAdmin = true;
                new Admin_Panel().Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Login lub PIN nieprawidłowe!");
                Login_Box.Clear();
                Pass_Box.Clear();
                Login_Box.Focus();
            }
        }
    }
}
