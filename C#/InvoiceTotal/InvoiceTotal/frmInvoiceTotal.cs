using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal (invoiceSubtotal.Text);
            decimal discountPercent = 0m;

            // If subtotal is greater than or equal to 500
            if (subtotal >= 500)
            {
                // Set discount to 20%.
                discountPercent = .2m;
            }
            // If subtotal is greater or equal to 250 and subtotal is less than 500
            else if (subtotal >= 250 && subtotal < 500)
            {
                // Set discount to 15%.
                discountPercent = .15m;
            }
            // If subtotal is greater than or equal to 100 and less than 250
            else if (subtotal >= 100 && subtotal < 250)
            {
                // Set discount to 10%.
                discountPercent = .1m;
            }

            // Set discountAmount and invoiceTotal according to math.
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // Return math to textbox and format properly.
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            // Set focus to invoiceSubtotal.
            invoiceSubtotal.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Close program.
            this.Close();
        }

    }
}