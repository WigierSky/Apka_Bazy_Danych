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
    public partial class Show_CDs : Form
    {
        public Show_CDs()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new CD_Panel().Show();
            this.Close();
        }

        private void Show_CDs_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  plyta_id, tytul.tytul, data_dodania, cena_zakupu, autorzy.imie_artysty, autorzy.nazwisko_artysty FROM plyta\r\nInner join tytul on plyta.tytul_id = tytul.tytul_id\r\nInner join autorzy on tytul.autor_id = autorzy.autor_id\r\nWHERE imie_artysty IS NOT NULL", Global.cnn);
            SqlDataAdapter sqlDax = new SqlDataAdapter("SELECT  plyta_id, tytul.tytul, data_dodania, cena_zakupu, autorzy.nazwa_zespolu FROM plyta\r\nInner join tytul on plyta.tytul_id = tytul.tytul_id\r\nInner join autorzy on tytul.autor_id = autorzy.autor_id\r\nWHERE nazwa_zespolu IS NOT NULL", Global.cnn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlDax.Fill(dt);

            dgvl.DataSource = dt;

            Global.cnn.Close();
        }
    }
}
