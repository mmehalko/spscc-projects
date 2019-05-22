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
        private InvoiceCalculator ic = new InvoiceCalculator();
        public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSubtotal.Text))
                {
                    return;
                }

                var subtotal = 0m;
                if (decimal.TryParse(txtSubtotal.Text, out subtotal))
                {
                    errorProvider1.Clear();

                    ic.Calculate(subtotal);

                    txtDiscountPercent.Text = InvoiceCalculator.DISCOUNTPERCENT.ToString("p0");
                    txtDiscountAmount.Text = ic.discountedAmount.ToString();
                    txtTotal.Text = ic.invoiceTotal.ToString();
                }
                else
                {
                    errorProvider1.SetError(txtSubtotal, "Subtotal is an invalid number.");
                }
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(txtSubtotal, ex.Message);
            }
            finally
            {
                txtSubtotal.Focus();
            }
         }

		private void btnExit_Click(object sender, EventArgs e)
		{
            // Close form.
			this.Close();
		}

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Clear();
            txtTotal.Clear();
            txtSubtotal.Clear();
            ic.Reset();
        }
    }
}