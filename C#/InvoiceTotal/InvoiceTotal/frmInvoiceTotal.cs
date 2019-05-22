using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Madison Mehalko.
// 11/1/2017.
// Excercise 7.
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
            const decimal DISCOUNTPERCENT = .25m;
            try
            {
                // Check if subtotal string is empty or not.
                if (String.IsNullOrEmpty(txtSubtotal.Text))
                {
                    // If empty, display message.
                    MessageBox.Show("Subtotal Entry is required.");
                }
                // if not empty, continue.
                else
                {
                    // Set variables. Turn subtotal into a decimal, set math.
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    decimal discountAmount = subtotal * DISCOUNTPERCENT;
                    decimal invoiceTotal = subtotal - discountAmount;

                    // Check to see if the subtotal entry is greater than 0 or less than 10,000. (Not equal to 0 or 10,000.)
                    if (subtotal > 0 && subtotal < 10000)
                    { 
                        // If entry is valid, round the discountAmount to the 2nd decimal.
                    discountAmount = Math.Round(discountAmount, 2);
                        // If entry is valid, round the invoiceTotal to the 2nd decimal.
                    invoiceTotal = Math.Round(invoiceTotal, 2);

                        // Convert and display totals.
                    txtDiscountPercent.Text = DISCOUNTPERCENT.ToString("p1");
                    txtDiscountAmount.Text = discountAmount.ToString();
                    txtTotal.Text = invoiceTotal.ToString();
                        // Focus back on the subtotal textbox.
                    txtSubtotal.Focus();
                    }
                    else
                    {
                        // If the entry is not between 1 and 9,999 show display message.
                        MessageBox.Show("Entry must be greater than 0 and less than 10,000.");
                    }
                }
            }
            catch
            {
                // If all things above fail, display error message.
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.",
                    "Entry Error");
            }
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            // Close form.
			this.Close();
		}

	}
}