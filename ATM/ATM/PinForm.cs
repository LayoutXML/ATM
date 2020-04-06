﻿using System;
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
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxPin.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Console.WriteLine(atmMachine.getAccount(accountNumber, TextBoxPin.Text));
            /*if(!isDataRace && currentAccountNum == atmMachine.getAccount(accountNumber, TextBoxPin.Text))
            {
                WaitOne();  //decrement semaphore thread number - needs to be released when transactions are complete with Release()
            }
            else currentAccountNum = atmMachine.getAccount(accountNumber, TextBoxPin.Text);*/
        }

        private void PinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
