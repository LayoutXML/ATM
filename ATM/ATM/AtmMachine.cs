using System;

namespace ATM
{
    public class AtmMachine
    {
        private Account[] ac;
        public Account activeAccount = null;
        public int localBalance;
        public int amountToWithdraw = 0;

        public AtmMachine(Account[] ac)
        {
            this.ac = ac;
            this.launchForm();
        }

        public void launchForm()
        {
            var atm = new AccountForm(this);
            System.Windows.Forms.Application.Run(atm); //launches account form
        }

        /*
         * Get account index in array based on accountnumber and pin.
         * Locks account after too many attempts (3)
         * If one of the inputs is incorrect, a default value (-1) is returned
         */
        public int getAccount(String accountNumber, String pin)
        {
            int index = -1;
            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum().ToString() == accountNumber)
                {
                    index = i;
                }
            }

            if (index >= 0)
            {
                if (!ac[index].checkPin(pin))
                {
                    return -1;
                }
            }

            if (index >= 0)
            {
                activeAccount = ac[index];
            }

            return index;
        }
    }
}
