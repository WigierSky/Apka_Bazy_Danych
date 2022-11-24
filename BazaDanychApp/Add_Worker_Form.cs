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
    public partial class Add_Worker_Form : Form
    {
        public Add_Worker_Form()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            new Worker_Panel().Show();
            this.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Worker_Panel().Show();
            this.Close();
        }
    }
}
