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
    }
}
