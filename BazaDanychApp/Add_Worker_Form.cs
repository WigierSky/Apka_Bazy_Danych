using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BazaDanychApp
{
    public partial class Add_Worker_Form : Form
    {

        public Add_Worker_Form()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string Name = Name_Textbox.Text;
            string Surname = Surname_textbox.Text;
            string Street = Street_textbox.Text;
            string House_Num = House_Nr_textbox.Text;
            int PESEL = Int32.Parse(PESEL_textbox.Text);
            int PIN = Int32.Parse(PIN_textbox.Text);
            string Post_Code = PostCode_textbox.Text;
            int Salary = Int32.Parse(Salary_textbox.Text);
            string tel_num = Phone_Num_textbox.Text;
            DateTime date = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";



            Global.cnn.Open();
 
            string command_addding = "INSERT INTO pracownik(data_zatrudnienia, pensja, PIN) VALUES (@date, @salary, @pin)";
            string command_nr = "INSERT INTO numer_tel(numer_tel_1, numer_tel_2, numer_tel_3) VALUES (@nr, NULL, NULL)";
            string adres = "INSERT INTO adres (ulica, nr_domu, kod_pocztowy, miasto_id) VALUES (@ulica, @nr_domu, kod, miasto_id)";

            SqlCommand com = new SqlCommand(command_addding, Global.cnn);
            com.Parameters.Add("@date", date.ToString(format));
            com.Parameters.Add("@salary", Salary);
            com.Parameters.Add("@pin", PIN);

            com.ExecuteNonQuery();

            SqlCommand comx = new SqlCommand(command_nr, Global.cnn);
            comx.Parameters.Add("@nr", tel_num);

            comx.ExecuteNonQuery();

            string command_sel_id = "SELECT pracownik_id FROM pracownik WHERE PIN = @pin";
            SqlCommand com1 = new SqlCommand(command_sel_id, Global.cnn);
            com1.Parameters.Add("@pin", PIN);

            // SqlDataReader reader = com1.ExecuteReader();
            Int32 id = (Int32)com1.ExecuteScalar();
            

            


            Global.cnn.Close();

            new Worker_Panel().Show();
            this.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Worker_Panel().Show();
            this.Close();
        }
    }
}
