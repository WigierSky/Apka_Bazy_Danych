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
    public partial class Add_CD_Panel : Form
    {
        public Add_CD_Panel()
        {
            InitializeComponent();
        }

        private void Add_CD_Panel_Load(object sender, EventArgs e)
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

      

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new CD_Panel().Show();
            this.Close();
        }

        private void Team_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

            Title_Box.Items.Clear();
            Author_Combo_Box.ResetText();

            Global.cnn.Open();

            string nazwa = Team_Combo_Box.Text;

            SqlCommand com = new SqlCommand("SELECT tytul from tytul WHERE autor_id = (SELECT autor_id from autorzy WHERE nazwa_zespolu = @nazwa)", Global.cnn);

            com.Parameters.AddWithValue("@nazwa", nazwa);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}",
                        reader[0]));
                }
            }
            Global.cnn.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            int price = 0;
            try
            {
                price = Convert.ToInt32(Price_TextBox.Text);
            }catch(System.FormatException f)
            {
                Price_TextBox.Clear();
                MessageBox.Show("Cena musi być liczbą!");
                
            }
         
            DateTime date = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string tytul = Title_Box.Text;

            Global.cnn.Open(); 

            if(Author_Combo_Box.Text == "" && Team_Combo_Box.Text != "" && tytul != "" && price != 0)
            {
                string nazwa = Team_Combo_Box.Text;

                SqlCommand com = new SqlCommand("INSERT INTO plyta (data_dodania, cena_zakupu, tytul_id, admin_id) VALUES (@data, @cena, (SELECT tytul_id from tytul WHERE tytul = @tytul AND autor_id = (SELECT autor_id from autorzy WHERE nazwa_zespolu = @nazwa)), 1)", Global.cnn);

                com.Parameters.AddWithValue("@data", date.ToString(format));
                com.Parameters.AddWithValue("@cena", price);
                com.Parameters.AddWithValue("@tytul", tytul);
                com.Parameters.AddWithValue("@nazwa", nazwa);

                com.ExecuteNonQuery();

                Team_Combo_Box.ResetText();
                Price_TextBox.ResetText();
                Title_Box.ResetText();
                Title_Box.Items.Clear();

                MessageBox.Show("Dodano płytę do tytułu " + tytul);
            }else if (Team_Combo_Box.Text == "" && Author_Combo_Box.Text != "" && tytul != "" && price != 0)
            {
                string imie = Author_Combo_Box.Text;
                string[] words = imie.Split(' ');

                SqlCommand com = new SqlCommand("INSERT INTO plyta (data_dodania, cena_zakupu, tytul_id, admin_id) VALUES (@data, @cena, (SELECT tytul_id from tytul WHERE tytul = @tytul AND autor_id = (SELECT autor_id from autorzy WHERE imie_artysty = @imie AND nazwisko_artysty = @nazwisko)), 1)", Global.cnn);

                com.Parameters.AddWithValue("@data", date.ToString(format));
                com.Parameters.AddWithValue("@cena", price);
                com.Parameters.AddWithValue("@tytul", tytul);
                com.Parameters.AddWithValue("@imie", words[0]);
                com.Parameters.AddWithValue("@nazwisko", words[1]);

                com.ExecuteNonQuery();

                Author_Combo_Box.ResetText();
                Price_TextBox.ResetText();
                Title_Box.ResetText();
                Title_Box.Items.Clear();

                MessageBox.Show("Dodano płytę do tytułu " + tytul);
            }
            else
            {
                MessageBox.Show("Wybierz autora i tytuł oraz podaj cene!");
            }

            Global.cnn.Close();
        }

        private void Author_Combo_Box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Team_Combo_Box.ResetText();
            Title_Box.Items.Clear();

            Global.cnn.Open();

            string imie = Author_Combo_Box.Text;
            string[] words = imie.Split(' ');

            SqlCommand com = new SqlCommand("SELECT tytul from tytul WHERE autor_id = (SELECT autor_id from autorzy WHERE imie_artysty = @imie AND nazwisko_artysty = @nazwisko)", Global.cnn);

            com.Parameters.AddWithValue("@imie", words[0]);
            com.Parameters.AddWithValue("@nazwisko", words[1]);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Title_Box.Items.Add(String.Format("{0}",
                        reader[0]));
                }
            }
            Global.cnn.Close();
        }
    }
}
