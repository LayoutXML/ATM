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
            labelBalance.Text += atmMachine.activeAccount.getBalance();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            new OptionForm(atmMachine).Show();
        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
