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
    public partial class OptionForm : Form
    {
        private AtmMachine atmMachine;

        public OptionForm(AtmMachine atmMachine)
        {
            this.atmMachine = atmMachine;
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new WithdrawMoneyForm(atmMachine).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new BalanceForm(atmMachine).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelOptions_Click(object sender, EventArgs e)
        {

        }

        private void InvalidOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invalid option for this screen selected", "Invalid Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
