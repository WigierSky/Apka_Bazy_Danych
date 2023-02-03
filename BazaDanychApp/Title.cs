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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Show_Titles_Butt_Click(object sender, EventArgs e)
        {
            new Show_Titles().Show();
            this.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Close();
        }

        private void Author_Title_Button_Click(object sender, EventArgs e)
        {
            new Add_Title().Show();
            this.Close();
        }

    }
}
