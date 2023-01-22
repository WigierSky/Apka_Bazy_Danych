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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string Name = Name_Textbox.Text;
            string Surname = Surname_textbox.Text;
            Int64 PESEL = 0;

            string Post_Code = PostCode_textbox.Text;
            string House_Num = House_Nr_textbox.Text;
            string num_miesz = Flat_nr_textbox.Text;
            string num_tel = Phone_Num_textbox.Text;
            string Street = Street_textbox.Text;
            string miasto = City_box.Text;


            try
            {
                PESEL = Int64.Parse(PESEL_textbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj prawidłowy PESEL!");
            }

            Global.cnn.Open();

            if (PESEL != 0 && Name != "" && Surname != "" && Post_Code != "" && House_Num != "" && num_tel != "" && Street != "" && miasto != "")
            {
                SqlCommand addAdd = new SqlCommand("INSERT INTO adres (ulica, nr_domu, nr_mieszkania, kod_pocztowy, miasto_id) VALUES (@ulica, @nrdomu, @mieszkanie, @kod, (SELECT miasto_id FROM miasto WHERE nazwa_miasta = @nazwamiasta))", Global.cnn);

                if (House_Num == "")
                {
                    addAdd.Parameters.AddWithValue("@mieszkanie", DBNull.Value);
                }
                else
                {
                    addAdd.Parameters.AddWithValue("@mieszkanie", num_miesz);
                }

                addAdd.Parameters.AddWithValue("@ulica", Street);
                addAdd.Parameters.AddWithValue("@nrdomu", House_Num);
                addAdd.Parameters.AddWithValue("@kod", Post_Code);
                addAdd.Parameters.AddWithValue("@nazwamiasta", miasto);

                try
                {
                    addAdd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    SqlCommand addcity = new SqlCommand("INSERT INTO miasto (nazwa_miasta) VALUES (@miasto)", Global.cnn);
                    addcity.Parameters.AddWithValue("@miasto", miasto);
                    addcity.ExecuteNonQuery();

                    addAdd.ExecuteNonQuery();
                }



                SqlCommand addClient = new SqlCommand("INSERT INTO klient (opis) VALUES (NULL)", Global.cnn);
                addClient.ExecuteNonQuery();

                SqlCommand addDane = new SqlCommand("INSERT INTO dane (imie, nazwisko, pesel, adres_id, numer_tel_id, klient_id) VALUES" +
                   " (@imie, @nazwisko, @pesel, (SELECT adres_id FROM adres WHERE ulica = @ulica AND nr_domu = @nrdomu AND nr_mieszkania = @nrmieszkania AND miasto_id = " +
                   "(SELECT miasto_id from miasto where nazwa_miasta = @miasto)), " +
                   "(SELECT numer_tel_id from numer_tel where numer_tel_1 = @numertel)," +
                   "(SELECT max(klient_id) FROM klient))", Global.cnn);

                addDane.Parameters.AddWithValue("@imie", Name);
                addDane.Parameters.AddWithValue("@nazwisko", Surname);
                addDane.Parameters.AddWithValue("@pesel", PESEL);
                addDane.Parameters.AddWithValue("@ulica", Street);
                addDane.Parameters.AddWithValue("@nrdomu", House_Num);
                addDane.Parameters.AddWithValue("@nrmieszkania", num_miesz);
                addDane.Parameters.AddWithValue("@miasto", miasto);
                addDane.Parameters.AddWithValue("@numertel", num_tel);
                bool success = false;

                try
                {
                    addDane.ExecuteNonQuery();
                    success = true;
                }
                catch (SqlException)
                {
                    try
                    {
                        string command_nr = "INSERT INTO numer_tel(numer_tel_1, numer_tel_2, numer_tel_3) VALUES (@nr, NULL, NULL)";

                        SqlCommand addNrTel = new SqlCommand(command_nr, Global.cnn);
                        addNrTel.Parameters.AddWithValue("@nr", num_tel);

                        addNrTel.ExecuteNonQuery();
                        addDane.ExecuteNonQuery();
                        success = true;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("PESEL juz istnieje!");
                        SqlCommand delcom = new SqlCommand("delete FROM klient where klient_id = (SELECT max(klient_id) from klient)", Global.cnn);
                        delcom.ExecuteNonQuery();

                        SqlCommand deladd = new SqlCommand("DELETE FROM adres where adres_id = (SELECT max(adres_id) from adres)", Global.cnn);
                        deladd.ExecuteNonQuery();

                        SqlCommand delnr = new SqlCommand("DELETE FROM numer_tel WHERE numer_tel_id = (SELECT max(numer_tel_id) FROM numer_tel)", Global.cnn);
                        delnr.ExecuteNonQuery();

                        success = false;
                    }
                }
                finally
                {
                    if (success)
                    {
                        MessageBox.Show("Dodano klienta!");
                    }
                }

            }

            PESEL_textbox.ResetText();
            Name_Textbox.ResetText();
            Surname_textbox.ResetText(); 
            PostCode_textbox.ResetText();
            House_Nr_textbox.ResetText();
            Flat_nr_textbox.ResetText();
            Phone_Num_textbox.ResetText();
            Street_textbox.ResetText();
            City_box.ResetText();

            Global.cnn.Close();

        }

    }
}
