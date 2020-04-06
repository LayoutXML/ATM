using System;
using System.Windows.Forms;

namespace ATM
{
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private int numberOfTries = 0;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return true;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(String pinEntered)
        {
            if (numberOfTries >= 3)
            {
                MessageBox.Show("Your card has been blocked", "Card Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pinEntered == pin.ToString())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Pin is incorrect", "Incorrect Pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfTries++;
                return false;
            }
        }

        public int getAccountNum()
        {
            return accountNum;
        }

    }
}
