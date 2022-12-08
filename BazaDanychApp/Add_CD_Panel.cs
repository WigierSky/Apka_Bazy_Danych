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
               
            string command_solo = "Select imie_artysty, nazwisko_artysty From autorzy Where nazwisko_artysty IS NOT NULL";
            string count = "Select COUNT(*) From autorzy";

           
           // SqlCommand counter = new SqlCommand(count, Global.cnn);

            //Int32 size = (Int32)counter.ExecuteScalar();


            SqlCommand com = new SqlCommand(command_team, Global.cnn);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {

                    Author_Combo_Box.Items.Add(String.Format("{0}",
                        reader[0]));
                }
            }

            SqlCommand com2 = new SqlCommand(command_solo, Global.cnn);

            using (SqlDataReader reader = com2.ExecuteReader())
            {
                while (reader.Read())
                {

                    Author_Combo_Box.Items.Add(String.Format("{0} {1}",
                        reader[0], reader[1]));
                }
            }

            Global.cnn.Close();
            //foreach authot in 
            // Author_Combo_Box.Items.Add();
        }
    }
}
