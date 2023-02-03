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
    public partial class Show_workers : Form
    {
        public Show_workers()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Worker_Panel().Show();
            this.Close();
        }

        private void Show_workers_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT imie, nazwisko, pesel, pracownik_id, ulica, nr_domu, nr_mieszkania, kod_pocztowy, nazwa_miasta FROM Dane_wszystkie WHERE pracownik_id IS NOT NULL", Global.cnn);
            DataTable dn = new DataTable();
            sqlDa.Fill(dn);

            dataGridView1.DataSource = dn;

            Global.cnn.Close();
        }

    }
}
