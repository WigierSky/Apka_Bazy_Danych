using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychApp
{
    public partial class ShowClosedLoans : Form
    {
        public ShowClosedLoans()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Loan_Panel().Show();
            this.Close();
        }

        private void ShowClosedLoans_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from Dane_wypozyczen_klienta WHERE data_oddania IS NOT NULL", Global.cnn);
            SqlDataAdapter sqlda2 = new SqlDataAdapter("SELECT wypozyczenie.klient_id, data_wypozyczenia, tytul.tytul, wypozyczenie.plyta_id, data_oddania, cena_wypozyczenia, liczba_dni_wyp, autorzy.imie_artysty, autorzy.nazwisko_artysty, autorzy.nazwa_zespolu\r\nFROM wypozyczenie\r\nINNER JOIN tytul ON tytul.tytul_id = (SELECT tytul_id FROM plyta Where plyta_id = wypozyczenie.plyta_id)\r\nINNER JOIN autorzy ON autorzy.autor_id = tytul.autor_id\r\nWHERE klient_id IN (SELECT klient_id FROM klient WHERE opis = 'Usunieto')", Global.cnn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            sqlda2.Fill(dt);

            dgvl.DataSource = dt;

            Global.cnn.Close();
        }

    }
}
