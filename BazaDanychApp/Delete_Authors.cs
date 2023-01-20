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
    public partial class Delete_Authors : Form
    {
        public Delete_Authors()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Authors().Show();
            this.Close();
        }

        private void Delete_Authors_Load(object sender, EventArgs e)
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

        public void Resetx()
        {
            Author_Combo_Box.Items.Clear();
            Team_Combo_Box.Items.Clear();

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
 
        }

        private bool validateUserEntry()
        {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "UWAGA! Usunięcie autora powoduje usunięcie wszystkich płyt i tytułów przypisanych do niego! \n Czy chcesz kontynuować?";
                string caption = "Czy nadal chcesz usunąć autora?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                // Closes the parent form.
                    return true;
                    this.Close();
                }

            return false;
        }
        

        private void Del_Butt_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();
            string imie = Author_Combo_Box.Text;
            string[] words = imie.Split(' ');
            string nazwa = Team_Combo_Box.Text;

            if(validateUserEntry() == true)
            {
                if (nazwa != "")
                {
                    SqlCommand comm = new SqlCommand("DELETE FROM autorzy WHERE nazwa_zespolu = @nazwa", Global.cnn);
                    SqlCommand comm_del_CD = new SqlCommand("DELETE From plyta where tytul_id IN (SELECT tytul_id from tytul where autor_id IN (select autor_id from autorzy where nazwa_zespolu = @nazwa))", Global.cnn);
                    SqlCommand comm_del_tit = new SqlCommand("DELETE FROM tytul where autor_id in (SELECT autor_id From autorzy where nazwa_zespolu = @nazwa)", Global.cnn);

                    comm.Parameters.AddWithValue("@nazwa", nazwa);
                    comm_del_CD.Parameters.AddWithValue("@nazwa", nazwa);
                    comm_del_tit.Parameters.AddWithValue("@nazwa", nazwa);


                    comm_del_CD.ExecuteNonQuery();
                    comm_del_tit.ExecuteNonQuery();
                    comm.ExecuteNonQuery();

                    Team_Combo_Box.ResetText();
                    
                    Resetx();

                    MessageBox.Show("Usunięto zespół " + nazwa + " oraz wszystkie jego utwory!");

                }
                else if (imie != "")
                {
                    SqlCommand comm1 = new SqlCommand("DELETE FROM autorzy WHERE imie_artysty = @imie AND nazwisko_artysty = @nazwisko", Global.cnn);
                    SqlCommand comm_del_CDx = new SqlCommand("DELETE From plyta where tytul_id IN (SELECT tytul_id from tytul where autor_id IN (select autor_id from autorzy where imie_artysty = @imie AND nazwisko_artysty = @nazwisko))", Global.cnn);
                    SqlCommand comm_del_titx = new SqlCommand("DELETE FROM tytul where autor_id in (SELECT autor_id From autorzy where imie_artysty = @imie AND nazwisko_artysty = @nazwisko)", Global.cnn);

                    comm1.Parameters.AddWithValue("@imie", words[0]);
                    comm1.Parameters.AddWithValue("@nazwisko", words[1]);
                    comm_del_CDx.Parameters.AddWithValue("@imie", words[0]);
                    comm_del_CDx.Parameters.AddWithValue("@nazwisko", words[1]);
                    comm_del_titx.Parameters.AddWithValue("@imie", words[0]);
                    comm_del_titx.Parameters.AddWithValue("@nazwisko", words[1]);


                    comm_del_CDx.ExecuteNonQuery();
                    comm_del_titx.ExecuteNonQuery();
                    comm1.ExecuteNonQuery();

                    Author_Combo_Box.ResetText();
                    
                    Resetx();

                    MessageBox.Show("Usunięto artystę " + imie + " oraz wszystkie jego utwory!");
                }
                else
                {
                    MessageBox.Show("Wybierz autorów do usunięcia!");
                }
                
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
