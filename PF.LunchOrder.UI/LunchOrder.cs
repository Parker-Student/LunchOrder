using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF.LunchOrder.UI
{
    public partial class LunchOrder : Form
    {
        public LunchOrder()
        {
            InitializeComponent();
        }

        


        private void btnCalc_Click(object sender, EventArgs e)
        {

            double subtotal;
            double tax;
            double total;
            double chk1 = 0;
            double chk2 = 0;
            double chk3 = 0;
            double Ham = 0;
            double Pizza = 0;
            double Salad = 0;

            if (chkOpt1.Checked) { chk1 = 0.75;}
            if (chkOpt2.Checked) { chk2 = 0.75; }
            if (chkOpt3.Checked) { chk3 = 0.75; }
            if (radHamburger.Checked) { Ham = 6.95; }
            if (radPizza.Checked) { Pizza = 5.95; }
            if (radSalad.Checked) { Salad = 4.95; }


            subtotal = chk1 + chk2 + chk3 + Ham + Pizza + Salad;
            tax = subtotal * .0775;
            total = tax + subtotal;

            lblSubTotal.Text = subtotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
