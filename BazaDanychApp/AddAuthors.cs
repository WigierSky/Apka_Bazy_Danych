using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychApp
{
    public partial class AddAuthors : Form
    {
        public AddAuthors()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Authors().Show();
            this.Close();
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            string imie = "";
            string nazwisko = "";
            string nazwa = "";

            Global.cnn.Open();

            if (Artist_Butt.Checked && Name_Textbox.Text != "")
            {
                imie = Name_Textbox.Text;
                nazwisko = Surname_TextBox.Text;

                string add = "INSERT INTO autorzy (imie_artysty, nazwisko_artysty, nazwa_zespolu) VALUES(@imie, @nazwisko, NULL)";
                SqlCommand com = new SqlCommand(add, Global.cnn);

                com.Parameters.AddWithValue("@imie", imie);
                com.Parameters.AddWithValue("@nazwisko", nazwisko);

                com.ExecuteNonQuery();

                Name_Textbox.ResetText();
                Surname_TextBox.ResetText();


                MessageBox.Show("Dodano autora " + imie + " "+ nazwisko);

            }
            else if (Team_Butt.Checked && Team_TextBox.Text != "")
            {
                nazwa = Team_TextBox.Text;
                string addx = "INSERT INTO autorzy (imie_artysty, nazwisko_artysty, nazwa_zespolu) VALUES(NULL, NULL, @nazwa)";
                SqlCommand comx = new SqlCommand(addx, Global.cnn);

                comx.Parameters.AddWithValue("@nazwa", nazwa);
                comx.ExecuteNonQuery();

                Team_TextBox.ResetText();

                MessageBox.Show("Dodano zespół: " + nazwa);
            }
            else
            {
                MessageBox.Show("Podaj nazwe zespołu lub dane artysty!");
            }
            Global.cnn.Close();

        }

    }
}
