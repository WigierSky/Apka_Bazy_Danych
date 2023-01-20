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
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Close();
        }

        private void Author_Show_Butt_Click(object sender, EventArgs e)
        {
            new Show_Authors().Show();
            this.Close();
        }

        private void Author_Add_Button_Click(object sender, EventArgs e)
        {
            new AddAuthors().Show();
            this.Close();
        }

        private void Author_Delete_Button_Click(object sender, EventArgs e)
        {
            new Delete_Authors().Show();
            this.Close();
        }
    }
}
