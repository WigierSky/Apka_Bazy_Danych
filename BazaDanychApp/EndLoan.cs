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
    public partial class EndLoan : Form
    {
        Int64 pesel = 0;

        public EndLoan()
        {
            InitializeComponent();
        }

        public void LoadOrders(string x)
        {
            pesel = Convert.ToInt64(x);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new ChooseClientEnd().Show();
            this.Close();
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            int grade = 0;

            try
            {
                grade = Convert.ToInt32(Grade_Box.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj właściwą ocenę!");
                Grade_Box.ResetText();
            }

            if (grade != 0 && Loan_Combo_Box.Text != "")
            {
                Global.cnn.Open();

                string Text = Loan_Combo_Box.Text;
                string[] words = Text.Split('.');

                DateTime date = DateTime.Now;
                SqlCommand comm2 = new SqlCommand("SELECT data_wypozyczenia, liczba_dni_wyp from wypozyczenie WHERE plyta_id = @id and data_oddania IS NULL", Global.cnn);
                comm2.Parameters.AddWithValue("@id", words[0]);

                DateTime date2 = DateTime.Now;
                int days = 0;

                using (SqlDataReader reader = comm2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        date2 = (DateTime)reader[0];
                        days = (int)reader[1];
                    }
                }

                var diff = date2 - date;

                if (diff.Days > days)
                {
                    MessageBox.Show("Przekroczono czas wypożyczenia!\nKara wynosi " + (5 * (diff.Days - days)).ToString() + " zł");

                }

                SqlCommand comm = new SqlCommand("UPDATE wypozyczenie SET data_oddania = @data, OCENA = @ocena, liczba_dni_wyp = @liczba WHERE plyta_id = @id and data_oddania IS NULL", Global.cnn);
                comm.Parameters.AddWithValue("@data", date);
                comm.Parameters.AddWithValue("@ocena", grade);
                comm.Parameters.AddWithValue("@id", words[0]);
                comm.Parameters.AddWithValue("@liczba", diff.Days);

                SqlCommand upd = new SqlCommand("UPDATE plyta SET dostepnosc = 1 WHERE plyta_id = @id", Global.cnn);
                upd.Parameters.AddWithValue("@id", words[0]);

                comm.ExecuteNonQuery();
                upd.ExecuteNonQuery();


                MessageBox.Show("Zakończono wypożyczenie!");


                Global.cnn.Close();
            }
            else {
                MessageBox.Show("Wybierz płytę i podaj ocene!");
            }
        }

        private void EndLoan_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();

            SqlCommand comm = new SqlCommand("SELECT plyta_id, tytul FROM Dane_wypozyczen_klienta WHERE klient_id = (SELECT klient_id from dane WHERE pesel = @pesel) AND data_oddania IS NULL", Global.cnn);
            comm.Parameters.AddWithValue("@pesel", pesel);

            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {

                    Loan_Combo_Box.Items.Add(String.Format("{0}.{1}",
                        reader[0], reader[1]));
                }
            }

            Global.cnn.Close();
        }
    }
}
