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
    public partial class Show_Clients : Form
    {
        public Show_Clients()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void Show_Clients_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT imie, nazwisko, pesel, klient_id, ulica, nr_domu, nr_mieszkania, kod_pocztowy, nazwa_miasta FROM Dane_wszystkie WHERE klient_id IS NOT NULL", Global.cnn);
            DataTable dn = new DataTable();
            sqlDa.Fill(dn);
            dataGridView1.DataSource = dn;
            Global.cnn.Close();
        }
    }
}
