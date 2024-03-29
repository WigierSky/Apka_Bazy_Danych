﻿using System;
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
    public partial class ChooseClientEdit : Form
    {
        public ChooseClientEdit()
        {
            InitializeComponent();
        }

        private void Back_Button_WP_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }

        private void Search_Butt_Click(object sender, EventArgs e)
        {
            Worker_Box.Items.Clear();
            Global.cnn.Open();

            string Name = Name_Textbox.Text;
            string Surname = Surname_textbox.Text;

            if (Name != "" && Surname != "")
            {
                SqlCommand comm = new SqlCommand("SELECT pesel from dane WHERE imie = @imie AND nazwisko = @nazwisko AND klient_id IS NOT NULL", Global.cnn);

                comm.Parameters.AddWithValue("@imie", Name);
                comm.Parameters.AddWithValue("@nazwisko", Surname);

                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Worker_Box.Items.Add(String.Format("{0} {1}, {2}",
                            Name, Surname, reader[0]));
                    }
                }
            }
            else
            {
                MessageBox.Show("Wpisz imie i nazwisko!");
                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
            }

            if (Worker_Box.Items.Count == 0)
            {
                MessageBox.Show("Nie ma takiego klienta!");
                Name_Textbox.ResetText();
                Surname_textbox.ResetText();
            }


            Global.cnn.Close();
        }

        private void Choose_Butt_Click(object sender, EventArgs e)
        {
            string Text = Worker_Box.Text;

            if (Text != "")
            {
                string[] words = Text.Split(' ');
                EditClient editClient = new EditClient();
                editClient.LoadOrders(words[2]);
                editClient.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz klienta!");
            }
        }

    }
}
