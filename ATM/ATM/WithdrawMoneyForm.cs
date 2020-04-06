using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class WithdrawMoneyForm : Form
    {
        private AtmMachine atmMachine;

        public WithdrawMoneyForm(AtmMachine atmMachine)
        {
            this.atmMachine = atmMachine;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void InsufficientFunds()
        {
            MessageBox.Show("Insufficient funds in your account balance", "Inssuficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Hide();
            new OptionForm(atmMachine).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 10)
            {
                InsufficientFunds();
            }
            else
            {
                atmMachine.activeAccount.decrementBalance(10);
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 20)
            {
                InsufficientFunds();
            }
            else
            {
                atmMachine.activeAccount.decrementBalance(20);
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 50)
            {
                InsufficientFunds();
            }
            else
            {
                atmMachine.activeAccount.decrementBalance(50);
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 100)
            {
                InsufficientFunds();
            }
            else
            {
                atmMachine.activeAccount.decrementBalance(100);
                Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 500)
            {
                InsufficientFunds();
            }
            else
            {
                atmMachine.activeAccount.decrementBalance(500);
                Hide();
            }
        }
    }
}
