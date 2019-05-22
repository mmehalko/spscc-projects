using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPresent(TextBox txtBox, string title)
        {
            // Checks to see if entry is empty. If it is empty, it will display an error.
            if (txtBox.Text == "")
            {
                MessageBox.Show(title + " is a required field.", "Entry Error");
                txtBox.Focus();
                return false;
            }
            // If not empty, returns true.
            return true;
        }

        private bool IsDecimal (TextBox txtBox, string title)
        {
            // Set variable and convert string into a decimal by TryParse.
            decimal number = 0m;
            if (!Decimal.TryParse(txtBox.Text, out number))
            {
                // If NOT a decimal, display message.
                MessageBox.Show(title + " must be a decimal.", "Entry Error");
                txtBox.Focus();
                return false;
            }
            // If a decimal, return true.
            return true;
        }
        private bool IsInt (TextBox txtBox, string title)
        {
            // Set variable and check if it's a valid integer.
            int number = 0;
            if (!Int32.TryParse(txtBox.Text, out number))
            {
                // If NOT an integer, display message.
                MessageBox.Show(title + " must be an integer.", "Entry Error");
                txtBox.Focus();
                return false;
            }
            // If an integer, return true.
            return true;
        }

        private bool IsWithinRange(TextBox txtBox, string title, decimal min, decimal max)
        {
            // Set variable and convert entry to a decimal.
            decimal number = Convert.ToDecimal(txtBox.Text);
            // Check to see if entry is less than min or greater than max. 
            // Min and Max determined in IsValid call.
            if ((number < min || number > max))
            {
                // If entry is less than min or greater than max, display message.
                MessageBox.Show(
                    title + " must be between " + min + " and " + max + ".", 
                    "Entry Error");
                txtBox.Focus();
                return false;
            }
            // If entry is greater than min or less than max, return true.
            return true;

        }

        private bool IsValid()
        {
            return
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 1000) &&

                IsPresent(txtYears, "Number of Years") &&
                IsInt(txtYears, "Numbers of Years") &&
                IsWithinRange(txtYears, "Numbers of Years", 1, 40);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = this.CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");

            }
        }

         private decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal monthlyInterestRate, int months)
            {
                decimal futureValue = 0m;
                for (int i = 0; i < months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment)
                                * (1 + monthlyInterestRate);
                }
                return futureValue;
            }

         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}