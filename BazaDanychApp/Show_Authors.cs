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
    public partial class Show_Authors : Form
    {
        public Show_Authors()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Authors().Show();
            this.Close();
        }

        private void Show_Authors_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT imie_artysty, nazwisko_artysty FROM autorzy WHERE imie_artysty IS NOT NULL", Global.cnn);
            SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT nazwa_zespolu from autorzy where nazwa_zespolu IS NOT NULL", Global.cnn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sqlDa.Fill(dt);
            sqlDa2.Fill(dt2);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;

            

            Global.cnn.Close();
        }

    }
}
