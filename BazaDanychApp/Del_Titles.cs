using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychApp
{
    public partial class Del_Titles : Form
    {
        public Del_Titles()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Title().Show();
            this.Close();
        }

        private void Author_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Del_Titles_Load(object sender, EventArgs e)
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

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();
            string title = Title_Box.Text;

            if(Author_Combo_Box.Text == "" && Team_Combo_Box.Text != "" && title != "")
            {
                string nazwa = Team_Combo_Box.Text;
                SqlCommand comm_del_CD = new SqlCommand("DELETE From plyta where tytul_id IN (SELECT tytul_id from tytul where autor_id IN (select autor_id from autorzy where nazwa_zespolu = @nazwa )AND tytul = @title)", Global.cnn);
                SqlCommand comm_del_tit = new SqlCommand("DELETE FROM tytul where autor_id in (SELECT autor_id From autorzy where nazwa_zespolu = @nazwa )AND tytul = @title", Global.cnn);

                comm_del_CD.Parameters.AddWithValue("@nazwa", nazwa);
                comm_del_CD.Parameters.AddWithValue("@title", title);
                comm_del_tit.Parameters.AddWithValue("@nazwa", nazwa);
                comm_del_tit.Parameters.AddWithValue("@title", title);

                comm_del_CD.ExecuteNonQuery();
                comm_del_tit.ExecuteNonQuery();

                Team_Combo_Box.ResetText();
                Title_Box.ResetText();
                Title_Box.Items.Clear();

                MessageBox.Show("Usunięto tytył " + nazwa + " - " + title);

            }else if(Team_Combo_Box.Text == "" && Author_Combo_Box.Text != "" && title != "")
            {
                string imie = Author_Combo_Box.Text;
                string[] words = imie.Split(' ');

                SqlCommand comm_del_CDx = new SqlCommand("DELETE From plyta where tytul_id IN (SELECT tytul_id from tytul where autor_id IN (select autor_id from autorzy where imie_artysty = @imie AND nazwisko_artysty = @nazwisko) AND tytul = @title)", Global.cnn);
                SqlCommand comm_del_titx = new SqlCommand("DELETE FROM tytul where autor_id in (SELECT autor_id From autorzy where imie_artysty = @imie AND nazwisko_artysty = @nazwisko) AND tytul = @title", Global.cnn);

                comm_del_CDx.Parameters.AddWithValue("@imie", words[0]);
                comm_del_CDx.Parameters.AddWithValue("@nazwisko", words[1]);
                comm_del_CDx.Parameters.AddWithValue("@title", title);
                comm_del_titx.Parameters.AddWithValue("@imie", words[0]);
                comm_del_titx.Parameters.AddWithValue("@nazwisko", words[1]);
                comm_del_titx.Parameters.AddWithValue("@title", title);

                comm_del_CDx.ExecuteNonQuery();
                comm_del_titx.ExecuteNonQuery();

                Author_Combo_Box.ResetText();
                Title_Box.ResetText();
                Title_Box.Items.Clear();

                MessageBox.Show("Usunięto tytuł " + imie + " - " + title);
            }
            else
            {
                MessageBox.Show("Wybierz autora i tytuł!");
            }

            Global.cnn.Close();
        }
    }
}
