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
    public partial class ShowLoans : Form
    {
        public ShowLoans()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Loan_Panel().Show();
            this.Close();
        }

        private void ShowLoans_Load(object sender, EventArgs e)
        {
            Global.cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from Dane_wypozyczen_klienta WHERE data_oddania is NULL", Global.cnn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);

            dgvl.DataSource = dt;

            Global.cnn.Close();
        }

    }
}
