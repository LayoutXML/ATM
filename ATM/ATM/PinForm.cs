using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class PinForm : Form
    {
        private AtmMachine atmMachine;
        private String accountNumber;

        public PinForm(AtmMachine atmMachine, String accountNumber)
        {
            this.atmMachine = atmMachine;
            this.accountNumber = accountNumber;
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text += ((Button)sender).Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            new AccountForm(atmMachine).Show(); //reopen previous form
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!Bank.isDataRace && Bank.currentAccountNum == accountNumber) //open correct form depending on whether account inputs are correct
            {
                Bank.AtmControl.WaitOne();  //decrement semaphore thread number - needs to be released when transactions are complete with Release()
            }
            else Bank.currentAccountNum = accountNumber;

            if (atmMachine.getAccount(accountNumber, TextBoxPin.Text) < 0)
            {
                Hide();
                new AccountForm(atmMachine).Show();
            }
            else
            {
                Hide();
                new OptionForm(atmMachine).Show();
            }

            atmMachine.localBalance = atmMachine.activeAccount.getBalance();
        }

        private void PinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
