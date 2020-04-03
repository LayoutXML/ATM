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

        private void NumberButton_Click(object sender, EventArgs e)
        {
            TextBoxAcc.Text += ((Button)sender).Text;
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
