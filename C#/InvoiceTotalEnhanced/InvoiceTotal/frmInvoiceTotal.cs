using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Madison Mehalko
// Assignment 4-2
// 10/11/2017

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        // Initialize variables and set to zero.
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m; 
        decimal invoiceAverage = 0m; 
        decimal largest = 0m; 
        decimal smallest = decimal.MaxValue;

        private void btnCalculate_Click(object sender, EventArgs e)
        {   // Cast subtotal, keep discount percent at 25% regardless of entry.
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text); 
			decimal discountPercent = .25m;
            // Set the discountAmount to read the subtotal * discountPercent and
            // round to only allow 2 decimal digits.
			decimal discountAmount = Math.Round(subtotal * discountPercent, 2); 
			decimal invoiceTotal = subtotal - discountAmount;

            // Convert the subtotal from a decimal to a string giving it
            // the ability to be formatted as currency with the above specified
            // decimal places (2).
            txtSubtotal.Text = subtotal.ToString("c");
			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString("c");
			txtTotal.Text = invoiceTotal.ToString("c");

            // Set variables.
            numberOfInvoices++; // Number of invoices +1.
            totalOfInvoices += invoiceTotal; // Add together and assign to variable.
            invoiceAverage = totalOfInvoices / numberOfInvoices; // Divide.


            //Set variables for Min/Max value.
            smallest = Math.Min(smallest, invoiceTotal); // Assigns whichever is smallest (smallest or invoiceTotal)
            largest = Math.Max(largest, invoiceTotal); // Assigns whichever is largest (largest or invoiceTotal)

            txtNumberOfInvoices.Text = numberOfInvoices.ToString(); // Convert to String.
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c"); // Convert to string, set format to currency.
            txtInvoiceAverage.Text = invoiceAverage.ToString("c"); // Convert to string, set format to currency.
            txtSmallestInvoice.Text = smallest.ToString("c"); // ^^ Displays smallest in the txtSmallest box.
            txtLargestInvoice.Text = largest.ToString("c"); // ^^


            txtEnterSubtotal.Clear(); // Clears subtotal text after information is displayed to user.
			txtEnterSubtotal.Focus(); // Brings focus back to the subtotal textbox.
		}

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            // Initialize variables and set to zero.
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;
            smallest = decimal.MaxValue;
            largest = 0m;

            // Clear text boxes for the ability to start over.
            txtNumberOfInvoices.Clear(); // Does the same thing as the code below.
            txtTotalOfInvoices.Text = ""; // Clears textbox.
            txtInvoiceAverage.Text = ""; 
            txtSmallestInvoice.Clear();
            txtLargestInvoice.Clear();
            txtSubtotal.Clear();
            txtDiscountPercent.Clear();
            txtDiscountAmount.Clear();
            txtTotal.Clear();

            txtEnterSubtotal.Focus(); // Bring focus back to subtotal textbox.
        }

        private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

    }
}