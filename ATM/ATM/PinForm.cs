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

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += "0";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text = "0";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
