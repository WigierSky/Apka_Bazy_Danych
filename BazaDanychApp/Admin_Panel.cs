using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychApp
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Edit_Loans_Button_Click(object sender, EventArgs e)
        {
            new Loan_Panel().Show();
            this.Close();
        }

        private void Edit_Workers_Button_Click(object sender, EventArgs e)
        {
            new Worker_Panel().Show();
            this.Close();
        }

        private void Edit_Clients_Button_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }

        private void Edit_CDs_Click(object sender, EventArgs e)
        {
            new CD_Panel().Show();
            this.Close();
        }

        private void Author_Edit_Button_Click(object sender, EventArgs e)
        {
            new Authors().Show();
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tittle_Edit_Button_Click(object sender, EventArgs e)
        {
            new Title().Show();
            this.Close();
        }

    }
}
