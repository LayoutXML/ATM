using System;
using System.Threading;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ATM;

public class Bank : Form
{
    private Panel controlPanel;
    Button quitButton;
    private Thread ATM1, ATM2;
    private Account[] ac = new Account[3];

    public Bank()
    {
        ClientSize = new Size(800, 600);
        SetupControlPanel();

        ac[0] = new Account(300, 1111, 111111);
        ac[1] = new Account(750, 2222, 222222);
        ac[2] = new Account(3000, 3333, 333333);


        ATM1 = new Thread(new ThreadStart(InitAtm));
        ATM1.Start();

        ATM2 = new Thread(new ThreadStart(InitAtm));
        ATM2.Start();
    }

    private void SetupControlPanel()
    {
        controlPanel = new Panel();
        this.Controls.Add(controlPanel);
        quitButton = new Button();
        quitButton.Text = "Quit";
        quitButton.Bounds = new Rectangle(8, 8, 80, 24);
        quitButton.Click += new EventHandler(quitButton_Click);
        controlPanel.Controls.Add(quitButton);
    }

    private void InitAtm()
    {
        var atm = new AtmMachine(ac);
        Console.WriteLine("test");
    }

    private void quitButton_Click(object sender, EventArgs args)
    {
        ATM1.Abort();
        ATM2.Abort();
        Application.Exit();
    }

    public static void Main()
    {
        Application.Run(new Bank());
    }
}