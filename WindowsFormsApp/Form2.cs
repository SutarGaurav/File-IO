using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class formRegistrationForm : Form
    {
        public formRegistrationForm()
        {
            InitializeComponent();
        }        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtEmail.Clear();
            txtConNum.Clear();
            txtAddress.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            lblShow.Text += $"{txtFName.Text}";
            lblShow.Text += $"\n";
            lblShow.Text += $"{txtEmail.Text}";
            lblShow.Text += $"\n";
            lblShow.Text += $"{txtConNum.Text}";
            lblShow.Text += $"\n";
            lblShow.Text += $"{txtAddress.Text}";
            lblShow.Text += $"\n";

        }


    }
}
