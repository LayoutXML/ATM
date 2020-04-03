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
    public partial class AccountForm : Form
    {

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new PinForm().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
