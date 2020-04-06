using System.Windows.Forms;
using ATM;

public class Bank : Form
{
    public static BankSystem bankSystem;

    public Bank()
    {

    }

    public static void Main()
    {
        bankSystem = new BankSystem();
        Application.Run(bankSystem);
    }
}