using BazaDanychApp;
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
    public partial class AddLoan : Form
    {
        int cena = 0;
        Int64 pesel = 0;

        public AddLoan()
        {
            InitializeComponent();
        }

        public void LoadOrders(string x)
        {
            pesel = Convert.ToInt64(x);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new ChooseClientLoan().Show();
            this.Close();
        }

        private void Author_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team_Combo_Box.ResetText();
            Title_Box.Items.Clear();
            Title_Box.ResetText();

            Global.cnn.Open();

            string imie = Author_Combo_Box.Text;
            string[] words = imie.Split(' ');

            SqlCommand com = new SqlCommand("SELECT plyta_id, tytul.tytul, tytul.cena, tytul.tytul_id from plyta\r\nINNER JOIN tytul ON plyta.tytul_id = tytul.tytul_id WHERE autor_id = (SELECT autor_id from autorzy WHERE imie_artysty = @imie AND nazwisko_artysty = @nazwisko) AND dostepnosc = 1", Global.cnn);

            com.Parameters.AddWithValue("@imie", words[0]);
            com.Parameters.AddWithValue("@nazwisko", words[1]);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}.{1}, {2}",
                        reader[0], reader[1], reader[2]));
                }
            }
            Global.cnn.Close();
        }

        private void AddLoan_Load(object sender, EventArgs e)
        {

            Global.cnn.Open();

            string command_team = "Select nazwa_zespolu From autorzy Where nazwa_zespolu IS NOT NULL";
            string command_solo = "Select imie_artysty, nazwisko_artysty From autorzy Where imie_artysty IS NOT NULL";

            SqlCommand com = new SqlCommand(command_team, Global.cnn);
            SqlCommand com1 = new SqlCommand(command_solo, Global.cnn);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Team_Combo_Box.Items.Add(String.Format("{0}",
                        reader[0]));
                }
            }

            using (SqlDataReader reader1 = com1.ExecuteReader())
            {
                while (reader1.Read())
                {

                    Author_Combo_Box.Items.Add(String.Format("{0} {1}",
                        reader1[0], reader1[1]));
                }
            }
            Global.cnn.Close();
        }

        private void Team_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Title_Box.Items.Clear();
            Author_Combo_Box.ResetText();
            Title_Box.ResetText();

            Global.cnn.Open();

            string nazwa = Team_Combo_Box.Text;

            SqlCommand com = new SqlCommand("SELECT plyta_id, tytul.tytul, tytul.cena, tytul.tytul_id from plyta\r\nINNER JOIN tytul ON plyta.tytul_id = tytul.tytul_id WHERE autor_id = (SELECT autor_id from autorzy WHERE nazwa_zespolu = @nazwa) AND dostepnosc = 1", Global.cnn);

            com.Parameters.AddWithValue("@nazwa", nazwa);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}.{1}, {2}",
                        reader[0], reader[1], reader[2]));
                }
            }
            Global.cnn.Close();
        }

        private void Title_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string all = Title_Box.Text;
            if (all != "")
            {
                Global.cnn.Open();

                string[] words = all.Split('.');

                SqlCommand comm = new SqlCommand("SELECT cena from tytul where tytul_id = (SELECT tytul_id from plyta where plyta_id = @id)", Global.cnn);
                comm.Parameters.AddWithValue("@id", words[0]);

                cena = Convert.ToInt32(comm.ExecuteScalar());

                Global.cnn.Close();
            }

        }

        private void Days_Box_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Days_Box.Text != "")
            {
                try
                {
                    x = Convert.ToInt32(Days_Box.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Liczba dni musi być liczbą!");
                    Days_Box.ResetText();

                }
            }
            else Price_TextBox.Text = "";

            if (x != 0 && cena != 0)
            {
                float final = cena * x / 5;

                Price_TextBox.Text = final.ToString();
            }
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Days_Box.Text);
            int y = Convert.ToInt32(Price_TextBox.Text);
            DateTime date = DateTime.Now;
            string format = "yyyy-MM-dd";
            
            int cena = 0;
            int liczba_dni = 0;

            string all = Title_Box.Text;
            string[] words = all.Split('.');

            try
            {
                cena = Convert.ToInt32(Price_TextBox.Text);
                liczba_dni = Convert.ToInt32(Days_Box.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cena i liczba dni musi być liczbą!");

            }


            Global.cnn.Open();

            SqlCommand com;

            if (cena != 0 && liczba_dni != 0)
            {

                if (Global.isAdmin)
                {
                    com = new SqlCommand("INSERT INTO wypozyczenie (data_wypozyczenia, cena_wypozyczenia, liczba_dni_wyp, klient_id, plyta_id, admin_id, tytul_id)" +
                        "VALUES (@data, @cena, @liczba_dni, (SELECT klient_id from dane WHERE pesel = @pesel), @plyta_id, 1, (SELECT tytul_id from plyta WHERE plyta_id = @plyt))", Global.cnn);

                    com.Parameters.AddWithValue("@data", date);
                    com.Parameters.AddWithValue("@cena", cena);
                    com.Parameters.AddWithValue("@liczba_dni", liczba_dni);
                    com.Parameters.AddWithValue("@pesel", pesel);
                    com.Parameters.AddWithValue("@plyta_id", Convert.ToInt32(words[0]));
                    com.Parameters.AddWithValue("@plyt", Convert.ToInt32(words[0]));


                    com.ExecuteNonQuery();
                }
                else if (!Global.isAdmin)
                {
                    com = new SqlCommand("INSERT INTO wypozyczenie (data_wypozyczenia, cena_wypozyczenia, liczba_dni_wyp, klient_id, plyta_id, pracownik_id, tytul_id)" +
                       "VALUES (@data, @cena, @liczba_dni, (SELECT klient_id from dane WHERE pesel = @pesel), @plyta_id, @idpracy, (SELECT tytul_id from plyta WHERE plyta_id = @plyt))", Global.cnn);

                    com.Parameters.AddWithValue("@data", date.ToString(format));
                    com.Parameters.AddWithValue("@cena", cena);
                    com.Parameters.AddWithValue("@liczba_dni", liczba_dni);
                    com.Parameters.AddWithValue("@pesel", pesel);
                    com.Parameters.AddWithValue("@plyta_id", Convert.ToInt32(words[0]));
                    com.Parameters.AddWithValue("@idpracy", Global.pracownik_id);
                    com.Parameters.AddWithValue("@plyt", Convert.ToInt32(words[0]));

                    com.ExecuteNonQuery();

                }

                SqlCommand com1 = new SqlCommand("UPDATE plyta SET dostepnosc = 0 WHERE plyta_id = @id ", Global.cnn);
                com1.Parameters.AddWithValue("@id", Convert.ToInt32(words[0]));
                com1.ExecuteNonQuery();

                MessageBox.Show("Dodano wypozyczenie!");

                Author_Combo_Box.ResetText();
                Team_Combo_Box.ResetText();
                Title_Box.ResetText();
                Title_Box.Items.Clear();
                Days_Box.ResetText();
                Price_TextBox.ResetText();



                Global.cnn.Close();

            }
        }
    }
}
