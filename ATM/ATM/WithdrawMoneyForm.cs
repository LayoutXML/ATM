using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
