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
    public partial class Worker_Panel : Form
    {
        public Worker_Panel()
        {
            InitializeComponent();
        }

        private void Back_Button_WP_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Close();
        }

        private void Add_Worker_Button_Click(object sender, EventArgs e)
        {
            new Add_Worker_Form().Show();
            this.Close();
        }

        private void Edit_Worker_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
