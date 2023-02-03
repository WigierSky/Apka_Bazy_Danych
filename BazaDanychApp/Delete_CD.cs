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
    public partial class Delete_CD : Form
    {
        public Delete_CD()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new CD_Panel().Show();
            this.Close();
        }

        private void Title_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Author_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team_Combo_Box.ResetText();
            Title_Box.Items.Clear();
            Title_Box.ResetText();

            Global.cnn.Open();

            string imie = Author_Combo_Box.Text;
            string[] words = imie.Split(' ');

            SqlCommand com = new SqlCommand("SELECT plyta_id, tytul.tytul from plyta\r\nINNER JOIN tytul ON plyta.tytul_id = tytul.tytul_id WHERE autor_id = (SELECT autor_id from autorzy WHERE imie_artysty = @imie AND nazwisko_artysty = @nazwisko)", Global.cnn);

            com.Parameters.AddWithValue("@imie", words[0]);
            com.Parameters.AddWithValue("@nazwisko", words[1]);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}.{1}",
                        reader[0], reader[1]));
                }
            }
            Global.cnn.Close();
        }

        private void Delete_CD_Load(object sender, EventArgs e)
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

            SqlCommand com = new SqlCommand("SELECT plyta_id, tytul.tytul from plyta\r\nINNER JOIN tytul ON plyta.tytul_id = tytul.tytul_id WHERE autor_id = (SELECT autor_id from autorzy WHERE nazwa_zespolu = @nazwa)", Global.cnn);

            com.Parameters.AddWithValue("@nazwa", nazwa);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}.{1}",
                        reader[0], reader[1]));
                }
            }
            Global.cnn.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();
            string title = Title_Box.Text;
            string[] tit_words = title.Split('.');

            if(title != "")
            {      
                SqlCommand comm = new SqlCommand("UPDATE plyta SET dostepnosc = '0' WHERE plyta_id = @id", Global.cnn);
                comm.Parameters.AddWithValue("@id", Convert.ToInt32(tit_words[0]));

                comm.ExecuteNonQuery();

                Author_Combo_Box.ResetText();
                Title_Box.ResetText();
                Team_Combo_Box.ResetText();
                Title_Box.Items.Clear();

                MessageBox.Show("Usunięto płytę o nr." + tit_words[0]);

            }
            else
            {
                MessageBox.Show("Wybierz płytę do usunięcia!");
            }

            Global.cnn.Close();

        }

    }
}
