using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchesAndLoops
{
    public partial class UsingLoopsForm : Form
    {
        public UsingLoopsForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // execute specified loop if entries are valid
            // variable for errors;
            string errorMessage;
            // are entries valid?
            // is type of loop for or while?
            string loopType = txtLoop.Text.ToLower(); // reads loop as lower case entries and assign to variable.
            switch (loopType)
            {
                case "for": // if the value in the text box = for or while
                case "while":
                    errorMessage = ""; // variable is an empty string, display if above qualifications are met.
                    break; // if the value does not match the above qualifications, go on to the next option.
                default:
                    errorMessage = "Loop type not found. "; // If variables are not met, message is read out.
                    break;
            }

            // is start value a decimal > 0?
            decimal startValue; 
            if (decimal.TryParse(txtStart.Text, out startValue)) // parse txtStart into a decimal and read it out as your above variable (startValue)
            {
                if (startValue <= 0) // is entered number above zero?
                    errorMessage += "Start value needs to be more than zero."; // User gave a number that can't be used. Error displayed.
            }
            else
                errorMessage += "Start value needs to be a decimal more than zero."; // if number isn't entered, error message is read out.

            // is end value a decimal > 0?
            decimal endValue; // variable for txtEnd.
            if (decimal.TryParse(txtEnd.Text, out endValue)) // parse txtEnd into a decimal and read it out as above variable (endValue).
            {
                // If entered endValue (from txtEnd) reads a number but less than zero, show error message.
                if (endValue <= 0) 
                    errorMessage += "End value needs to be more than zero."; 
            }
            else
                // If entered text isn't a number, show error message.
                errorMessage += "End value needs to be a decimal more than zero.";

            // is step value a decimal > 0?
            decimal stepValue; // variable for txtStep
            if (decimal.TryParse(txtStep.Text, out stepValue)) // parse txtStep into a deceimal and read it out as above variable.
            {
                if (stepValue <= 0)
                    errorMessage += "Step value needs to be more than zero.";
            }
            else
                errorMessage += "Step value needs to be a decimal more than zero.";

            // if all entries ok, is start < end?
            if (errorMessage == "")
            {
                // is start < end?
                if (startValue < endValue)
                {
                    // run loop
                    // clear display label
                    lblStatus.Text = string.Empty;

                    // determine kind of loop
                    switch(loopType)
                    {
                        case "for": // if loop type is 'for'
                            for (decimal counter = startValue ; // counter is a decimal, start at startValue 
                            counter <= endValue; counter += stepValue) // if counter is less than or equal to endValue, increase by 1.
                            // once our counter hits our end value, the loop stops at the break and continues
                            {
                                lblStatus.Text += ".";
                            }
                            break;
                        /*case "while": // if loop type is 'while'
                            break;*/
                        default: // acts like an 'else' statement. If loop type is not 'for', display information below.
                            while (startValue<=endValue)
                            {
                                startValue += stepValue;
                                lblStatus.Text += ".";
                            }
                            break;
                    }

                }
                else
                    errorMessage = "Start value must be less than end value.";
            }
            if (errorMessage != "") // If there is not equal to an empty string...
                lblStatus.Text = errorMessage; // Display your errorMessage in your display label.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear form for new entry
            txtLoop.Clear();
            txtStart.Clear();
            txtEnd.Clear();
            txtStep.Clear();
            lblStatus.Text = string.Empty;
            txtLoop.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close and exit
            Close();
        }

        private void UsingLoopsForm_Load(object sender, EventArgs e)
        {
            // clear display label
            lblStatus.Text = string.Empty;
        }
    }
}
