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
    public partial class WorkerLogin : Form
    {
        public WorkerLogin()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Loans_Button_Click(object sender, EventArgs e)
        {
            new Loan_Panel().Show();
            this.Close();
        }

        private void Edit_Clients_Button_Click(object sender, EventArgs e)
        {
            new Client_Panel().Show();
            this.Close();
        }
    }
}
