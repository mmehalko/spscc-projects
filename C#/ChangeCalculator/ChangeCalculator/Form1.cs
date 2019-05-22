using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Madison Mehalko
        // 11/08/17
        // Homework 7

        // Is it present?
        private bool IsPresent(string entry)
        {
            return entry != "";
        }
        // Is it a decimal?
        private bool IsDecimal (string entry)
        {
            return Decimal.TryParse(entry, out decimal value);
        }
        // Is it an integer?
        private bool IsInt(string entry)
        {
            return int.TryParse(entry, out int value);
        }
        // Is it within range?
        private bool IsInRange(decimal value, decimal min, decimal max)
        {
            return value > min && value < max;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Set variables and constants.
            string message = "";
            const int MIN = 0;
            const int MAX = 100;

            string scent = txtChange.Text;

            // Is there an entry?
            if (IsPresent(scent))
            { // Is it an intger?
                if (IsInt(scent))
                { // Convert to int.
                    int icent = Convert.ToInt32(txtChange.Text);
                    // Is it within range?
                    if (IsInRange(icent, MIN, MAX))
                    { // If it meets above validation, do the math!
                        int quarters = (int)(icent / 25);
                        icent = icent % 25;

                        int dimes = (int)(icent / 10);
                        icent = icent % 10;

                        int nickels = (int)(icent / 5);

                        int pennies = icent % 5;

                        txtQuarters.Text = quarters.ToString();
                        txtDimes.Text = dimes.ToString();
                        txtNickels.Text = nickels.ToString();
                        txtPennies.Text = pennies.ToString();

                    }
                    else
                    { // If it doesn't meet the min/max requirements, read message.
                        message = string.Format("{0} is not a valid entry between 1 and 99", icent);
                    }
                }
                else
                {// If it doesn't meet the int validation, read message.
                    message = string.Format("{0} isn't a valid integer.", scent);
                }
            }
            else
            {// If entry is empty, read message.
                message = "Need to enter a number.";
            }

            errorProvider1.SetError(txtChange, message); // Have error provider read out error message.
            txtChange.Focus(); // Focus change textbox.

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
