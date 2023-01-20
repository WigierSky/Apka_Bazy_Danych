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
    public partial class Add_Title : Form
    {
        public Add_Title()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Title().Show();
            this.Close();
        }

        private void Add_Title_Load(object sender, EventArgs e)
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

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();
            string imie = Author_Combo_Box.Text;
            string[] words = imie.Split(' ');
            string nazwa = Team_Combo_Box.Text;
            string tytul = Title_Text_Box.Text;
            DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
            int price = 0;

            try
            {
                price = Convert.ToInt32(Price_TextBox.Text);
            }
            catch (System.FormatException f)
            {
                Price_TextBox.Clear();
                MessageBox.Show("Cena musi być liczbą!");
            }


            if (imie != "" && tytul != "" && price != 0)
            { 
                SqlCommand sqlcom = new SqlCommand("INSERT INTO tytul (tytul, data_premiery, cena, autor_id, admin_id) VALUES (@tytul, @data_premiery, @cena, (SELECT autor_id FROM autorzy where imie_artysty = @imie AND nazwisko_artysty = @nazwisko), 1)", Global.cnn);
                sqlcom.Parameters.AddWithValue("@tytul", tytul);
                sqlcom.Parameters.AddWithValue("@data_premiery", date);
                sqlcom.Parameters.AddWithValue("@cena", price);
                sqlcom.Parameters.AddWithValue("@imie", words[0]);
                sqlcom.Parameters.AddWithValue("@nazwisko", words[1]);

                sqlcom.ExecuteNonQuery();

                Title_Text_Box.ResetText();
                Price_TextBox.ResetText();
                Author_Combo_Box.ResetText();

                MessageBox.Show("Dodano nowy tytuł " + tytul);
            }
            else if (nazwa != "" && tytul != "" && price != 0)
            {
                SqlCommand sqlcom = new SqlCommand("INSERT INTO tytul (tytul, data_premiery, cena, autor_id, admin_id) VALUES (@tytul, @data_premiery, @cena, (SELECT autor_id FROM autorzy where nazwa_zespolu = @nazwa), 1)", Global.cnn);
                sqlcom.Parameters.AddWithValue("@tytul", tytul);
                sqlcom.Parameters.AddWithValue("@data_premiery", date);
                sqlcom.Parameters.AddWithValue("@cena", price);
                sqlcom.Parameters.AddWithValue("@nazwa", nazwa);

                sqlcom.ExecuteNonQuery();

                Title_Text_Box.ResetText();
                Price_TextBox.ResetText();
                Team_Combo_Box.ResetText();

                MessageBox.Show("Dodano nowy tytuł " + tytul);
            }
            else
            {
                MessageBox.Show("Wybierz autora oraz podaj cene i tytuł!");
            }

            

            Global.cnn.Close();
        }

        private void Author_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team_Combo_Box.ResetText();
        }

        private void Team_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author_Combo_Box.ResetText();
        }
    }
}
