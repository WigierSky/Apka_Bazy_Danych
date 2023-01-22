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
    public partial class EditWorker : Form
    {
        Int64 pesel = 0;

        public EditWorker()
        {
            InitializeComponent();
        }

        public void LoadOrders(string x)
        {
            pesel = Convert.ToInt64(x);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new ChooseWorkerEdit().Show();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Global.cnn.Open();

            string name = Name_Textbox.Text;
            string surname = Surname_textbox.Text;
       
            int Salary = 0;
            string Post_Code = PostCode_textbox.Text;
            string House_Num = House_Nr_textbox.Text;
            string num_miesz = Flat_nr_textbox.Text;
            string num_tel = Phone_Num_textbox.Text;
            string Street = Street_textbox.Text;
            string miasto = City_box.Text;

            try
            {
                
                Salary = Int32.Parse(Salary_textbox.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("Pensja muszi być liczbą!");
            }

            if (name != "" && surname != "" &&  Salary != 0 && Post_Code != "" && House_Num != "" && num_tel != "" && Street != "" && miasto != "")
            {
                SqlCommand comm = new SqlCommand("UPDATE adres SET ulica = @ulica, nr_mieszkania = @mieszkanie, kod_pocztowy = @kod, miasto_id = (SELECT miasto_id FROM miasto WHERE nazwa_miasta = @nazwamiasta) WHERE adres_id = (SELECT adres_id from dane WHERE pesel = @pesel)", Global.cnn);

                if (House_Num == "")
                {
                    comm.Parameters.AddWithValue("@mieszkanie", DBNull.Value);
                }
                else
                {
                    comm.Parameters.AddWithValue("@mieszkanie", num_miesz);
                }

                comm.Parameters.AddWithValue("@ulica", Street);
                comm.Parameters.AddWithValue("@nrdomu", House_Num);
                comm.Parameters.AddWithValue("@kod", Post_Code);
                comm.Parameters.AddWithValue("@nazwamiasta", miasto);
                comm.Parameters.AddWithValue("@pesel", pesel);

                try
                {
                   comm.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    SqlCommand addcity = new SqlCommand("INSERT INTO miasto (nazwa_miasta) VALUES (@miasto)", Global.cnn);
                    addcity.Parameters.AddWithValue("@miasto", miasto);
                    addcity.ExecuteNonQuery();

                    comm.ExecuteNonQuery();
                }


                SqlCommand upnr = new SqlCommand("UPDATE numer_tel SET numer_tel_1 = @numer WHERE numer_tel_id = (SELECT numer_tel_id from dane WHERE pesel = @pesel)", Global.cnn);

                upnr.Parameters.AddWithValue("@numer", num_tel);
                upnr.Parameters.AddWithValue("@pesel", pesel);

                upnr.ExecuteNonQuery();


                SqlCommand upwork = new SqlCommand("UPDATE pracownik SET pensja = @pensja WHERE pracownik_id = (SELECT pracownik_id from dane WHERE pesel = @pesel)", Global.cnn);

                upwork.Parameters.AddWithValue("@pensja", Salary);
                upwork.Parameters.AddWithValue("@pesel",pesel);

                upwork.ExecuteNonQuery();


                SqlCommand updata = new SqlCommand("UPDATE dane SET imie = @imie, nazwisko = @nazwisko WHERE pesel = @pesel", Global.cnn);

                updata.Parameters.AddWithValue("@imie", name);
                updata.Parameters.AddWithValue("@nazwisko", surname);
                updata.Parameters.AddWithValue("@pesel", pesel);
                updata.ExecuteNonQuery();

                MessageBox.Show("Zaaktualizowano!");

                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
                Salary_textbox.ResetText();
                PostCode_textbox.ResetText();
                House_Nr_textbox.ResetText();
                Flat_nr_textbox.ResetText();
                Phone_Num_textbox.ResetText();
                Street_textbox.ResetText();
                City_box.ResetText();

            }
            else
            {
                MessageBox.Show("Podaj wszystkie dane!");
            }




            Global.cnn.Close();
        }

        private void EditWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
