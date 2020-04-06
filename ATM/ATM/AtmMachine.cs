using System;

namespace ATM
{
    class AtmMachine
    {
        private Account[] ac;
        private Account activeAccount = null;

        public AtmMachine(Account[] ac)
        {
            this.ac = ac;
            this.launchForm();
        }

        public void launchForm()
        {
            var atm = new AccountForm();
            System.Windows.Forms.Application.Run(atm);
            atm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Atm_FormClosed);
        }

        private void Atm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            // is not called for some reason :/
            Console.WriteLine("closed");
            Console.WriteLine(((AccountForm) sender).getAccountNumber());


            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum().ToString() == ((AccountForm)sender).getAccountNumber())
                {
                    Console.WriteLine(i);
                }
            }
        }

        /*
         * 
         * offer withdrawable amounts
         * 
         * based on input attempt to withraw the corosponding amount of money
         * 
         */
        private void dispWithdraw()
        {
            Console.WriteLine("1> 10");
            Console.WriteLine("2> 50");
            Console.WriteLine("3> 500");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0 && input < 4)
            {

                //opiton one is entered by the user
                if (input == 1)
                {

                    //attempt to decrement account by 10 punds
                    if (activeAccount.decrementBalance(10))
                    {
                        //if this is possible display new balance and await key press
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        //if this is not possible inform user and await key press
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
                else if (input == 2)
                {
                    if (activeAccount.decrementBalance(50))
                    {
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
                else if (input == 3)
                {
                    if (activeAccount.decrementBalance(500))
                    {
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
            }
        }

    }
}
