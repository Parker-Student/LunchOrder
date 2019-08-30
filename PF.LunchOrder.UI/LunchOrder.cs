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

       
        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            double subtotal;
            double tax;
            double total;
            double piz1 = 0;
            double piz2 = 0;
            double piz3 = 0;
            double sal1 = 0;
            double sal2 = 0;
            double sal3 = 0;
            double ham1 = 0;
            double ham2 = 0;
            double ham3 = 0;
            double Ham = 0;
            double Pizza = 0;
            double Salad = 0;

            if (chkZa1.Checked) { piz1 = 0.50; }
            if (chkZa2.Checked) { piz2 = 0.50; }
            if (chkZa3.Checked) { piz3 = 0.50; }
            if (chkSal1.Checked) { sal1 = 0.25; }
            if (chkSal2.Checked) { sal2 = 0.25; }
            if (chkSal3.Checked) { sal3 = 0.25; }
            if (chkHam1.Checked) { ham1 = 0.75; }
            if (chkHam2.Checked) { ham2 = 0.75; }
            if (chkHam3.Checked) { ham3 = 0.75; }
            if (radHamburger.Checked) { Ham = 6.95; }
            if (radPizza.Checked) { Pizza = 5.95; }
            if (radSalad.Checked) { Salad = 4.95; }


            subtotal = ham1 + ham2+ ham3 + piz1 + piz2 + piz3 + sal1 + sal2 + sal3 + Ham + Pizza + Salad;
            tax = subtotal * .0775;
            total = tax + subtotal;

            lblSubTotal.Text = subtotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;

            if (radHamburger.Checked)
            {
                lblHamCost.Show();
                chkHam1.Show();
                chkHam2.Show();
                chkHam3.Show();
            }
            else
            {
                lblHamCost.Hide();
                chkHam1.Hide();
                chkHam2.Hide();
                chkHam3.Hide();
                chkHam1.Checked = false;
                chkHam2.Checked = false;
                chkHam3.Checked = false; 
            }
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;

            if (radPizza.Checked)
            {
                lblZa.Show();
                chkZa1.Show();
                chkZa2.Show();
                chkZa3.Show();
            }
            else
            {
                lblZa.Hide();
                chkZa1.Hide();
                chkZa2.Hide();
                chkZa3.Hide();
                chkZa1.Checked = false;
                chkZa2.Checked = false;
                chkZa3.Checked = false;
            }
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;

            if (radSalad.Checked)
            {
                lblSal.Show();
                chkSal1.Show();
                chkSal2.Show();
                chkSal3.Show();
            }
            else
            {
                lblSal.Hide();
                chkSal1.Hide();
                chkSal2.Hide();
                chkSal3.Hide();
                chkSal1.Checked = false;
                chkSal2.Checked = false;
                chkSal3.Checked = false; ;
            }

          
        }

        private void chkSal1_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkSal2_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkSal3_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkHam2_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkHam1_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkZa3_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkHam3_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkZa2_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        private void chkZa1_CheckedChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }
    }
}
