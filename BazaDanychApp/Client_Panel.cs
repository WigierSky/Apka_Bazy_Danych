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
    public partial class Client_Panel : Form
    {
        public Client_Panel()
        {
            InitializeComponent();
        }

        private void add_client_button_click(object sender, EventArgs e)
        {

        }

        private void edit_client_button_click(object sender, EventArgs e)
        {

        }

        private void delete_client_buttno_click(object sender, EventArgs e)
        {

        }

        private void back_button_client_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Close();
        }

        private void display_client_button_Click(object sender, EventArgs e)
        {
            new Show_Clients().Show();                
            this.Close();

        }
    }
}
