using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += ((Button)sender).Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }

        private void PinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
