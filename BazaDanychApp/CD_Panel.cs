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
    public partial class CD_Panel : Form
    {
        public CD_Panel()
        {
            InitializeComponent();
        }

        private void Add_CD_Button_Click(object sender, EventArgs e)
        {
            new Add_CD_Panel().Show();
            this.Hide();
        }

        private void Edit_CD_Button_Click(object sender, EventArgs e)
        {
            new Show_CDs().Show();
            this.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Close();
        }

        private void Del_CD_Button_Click(object sender, EventArgs e)
        {
            new Delete_CD().Show();
            this.Close();
        }


    }
}
