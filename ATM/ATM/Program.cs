using System.Windows.Forms;
using System.Threading;
using ATM;

public class Bank : Form
{
    public static BankSystem bankSystem;
    public static string currentAccountNum;
    public static bool isDataRace;
    public static Semaphore AtmControl = new Semaphore(0, 1, "AtmControl");    //call WaitOne whenever a null current account, or the same current account, is being accessed by a thread
                                                                        //reset currentAccount to null after usage

    public Bank()
    {

    }

    public static void Main()
    {
        bankSystem = new BankSystem();
        Application.Run(bankSystem);
    }
}