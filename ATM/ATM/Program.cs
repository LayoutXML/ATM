using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using ATM;

public class Bank : Form
{
    private Panel controlPanel;
    Button quitButton;

    public Bank()
    {
        ClientSize = new Size(800, 600);
    }

    public static void Main()
    {
        Application.Run(new BankSystem());
    }
}