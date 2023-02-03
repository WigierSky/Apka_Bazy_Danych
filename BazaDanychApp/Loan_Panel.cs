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
    public partial class Loan_Panel : Form
    {
        public Loan_Panel()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (Global.isAdmin)
            {
                new Admin_Panel().Show();
                this.Close();
            }
            else if (!Global.isAdmin)
            {
                new WorkerLogin().Show();
                this.Close();
            }
        }

        private void Add_Loan_Click(object sender, EventArgs e)
        {
            new ChooseClientLoan().Show();
            this.Close();
        }

        private void Show_Loans_Click(object sender, EventArgs e)
        {
            new ShowLoans().Show();
            this.Close();
        }

        private void Show_Dead_Click(object sender, EventArgs e)
        {
            new ShowClosedLoans().Show();
            this.Close();
        }

        private void End_Loan_Click(object sender, EventArgs e)
        {
            new ChooseClientEnd().Show();
            this.Close();
        }

    }
}
