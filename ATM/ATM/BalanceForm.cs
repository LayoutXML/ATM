using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class BalanceForm : Form
    {
        private AtmMachine atmMachine;

        public BalanceForm(AtmMachine atmMachine)
        {
            this.atmMachine = atmMachine;
            InitializeComponent();
            labelBalance.Text += atmMachine.localBalance;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            new OptionForm(atmMachine).Show();
        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }

        private void labelOptions_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing receipt...", "Printing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InvalidOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invalid option for this screen selected", "Invalid Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
