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
    public partial class Delete_Client : Form
    {
        public Delete_Client()
        {
            InitializeComponent();
        }

        private void Back_Button_WP_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }

        private void Search_Butt_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();

            string Name = Name_Textbox.Text;
            string Surname = Surname_textbox.Text;

            if (Name != "" && Surname != "")
            {
                SqlCommand comm = new SqlCommand("SELECT pesel from dane WHERE imie = @imie AND nazwisko = @nazwisko AND klient_id IS NOT NULL", Global.cnn);

                comm.Parameters.AddWithValue("@imie", Name);
                comm.Parameters.AddWithValue("@nazwisko", Surname);

                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Worker_Box.Items.Add(String.Format("{0} {1}, {2}",
                            Name, Surname, reader[0]));
                    }
                }
            }
            else
            {
                MessageBox.Show("Wpisz imie i nazwisko!");
                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
            }

            if (Worker_Box.Items.Count == 0)
            {
                MessageBox.Show("Nie ma takiego klienta!");
                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
            }

            Global.cnn.Close();

        }

        private void Del_butt_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();
            string Text = Worker_Box.Text;
            string[] words = Text.Split(' ');

            List<int> list = new List<int>();

            SqlCommand comm3 = new SqlCommand("SELECT wypozyczenie_id from wypozyczenie WHERE data_oddania IS NULL AND klient_id = (SELECT klient_id FROM dane WHERE pesel = @pesel)", Global.cnn);
            comm3.Parameters.AddWithValue("@pesel", words[2]);
            using (SqlDataReader reader = comm3.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(Convert.ToInt32(String.Format("{0}", reader[0])));      
                }
            }

            if (Worker_Box.Text != "" && !list.Any())
            {

                string ids = "";

                SqlCommand take_ids = new SqlCommand("SELECT adres_id, numer_tel_id FROM dane WHERE pesel = @pesel", Global.cnn);
                take_ids.Parameters.AddWithValue("@pesel", words[2]);

                using (SqlDataReader reader = take_ids.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids = String.Format("{0} {1}", reader[0], reader[1]);
                    }
                }

                string[] ids_sep = ids.Split(' ');

                SqlCommand upd = new SqlCommand("UPDATE klient SET opis = @opis WHERE klient_id = (SELECT klient_id FROM dane WHERE pesel = @pesel)", Global.cnn);
                upd.Parameters.AddWithValue("@opis", "Usunięty");
                upd.Parameters.AddWithValue("@pesel", words[2]);
                upd.ExecuteNonQuery();


                SqlCommand deldata = new SqlCommand("DELETE from dane WHERE pesel = @pesel", Global.cnn);
                deldata.Parameters.AddWithValue("@pesel", words[2]);
                deldata.ExecuteNonQuery();

                SqlCommand delnum = new SqlCommand("DELETE FROM numer_tel WHERE numer_tel_id = @id", Global.cnn);
                delnum.Parameters.AddWithValue("@id", ids_sep[1]);
                delnum.ExecuteNonQuery();

                SqlCommand deladd = new SqlCommand("DELETE from adres WHERE adres_id = @id", Global.cnn);
                deladd.Parameters.AddWithValue("@id", ids_sep[0]);
                deladd.ExecuteNonQuery();

                

                MessageBox.Show("Usunięto klienta " + Name_Textbox.Text + " " +  Surname_textbox.Text);

                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
                Worker_Box.ResetText();
                Worker_Box.Items.Clear();

            }
            else if(Worker_Box.Text == "")
            {
                MessageBox.Show("Wybierz klienta!");
            }
            else
            {
                MessageBox.Show("Klient ma aktywne wypożyczenia!");
            }


            Global.cnn.Close();
        }

    }
}
