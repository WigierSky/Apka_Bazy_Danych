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
    public partial class Show_Titles : Form
    {
        public Show_Titles()
        {
            InitializeComponent();
        }


        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Title().Show();
            this.Close();
        }

        private void Show_Titles_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT tytul_id, tytul, data_premiery, cena, ocena_albumu, autorzy.imie_artysty, autorzy.nazwisko_artysty FROM tytul\r\nInner join autorzy on tytul.autor_id = autorzy.autor_id\r\nWHERE imie_artysty IS NOT NULL", Global.cnn);
            SqlDataAdapter sqlDax = new SqlDataAdapter("SELECT tytul_id, tytul, data_premiery, cena, ocena_albumu, autorzy.nazwa_zespolu FROM tytul\r\nInner join autorzy on tytul.autor_id = autorzy.autor_id\r\nWHERE nazwa_zespolu IS NOT NULL", Global.cnn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlDax.Fill(dt);

            dataGridView1.DataSource = dt;

            Global.cnn.Close();
        }
    }
}
