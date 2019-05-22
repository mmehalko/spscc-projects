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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check if change amount is valid.
            try
            {
                if (string.IsNullOrEmpty(txtChange.Text))
                {
                    return;
                }

                // Is an int
                var amount = 0;
                if (int.TryParse(txtChange.Text, out amount))
                {
                    errorProvider1.Clear();
                    var cc = new ChangeCalculator();


                    cc.Calculate(amount);

                    txtQuarters.Text = cc.quartersCount.ToString();
                    txtDimes.Text = cc.dimesCount.ToString();
                    txtNickels.Text = cc.nickelsCount.ToString();
                    txtPennies.Text = cc.penniesCount.ToString();
                }
                else
                {
                    errorProvider1.SetError(txtChange, "Need to enter a number.");
                }
            }

            catch (ArgumentException ex)
            {
                errorProvider1.SetError(txtChange, ex.Message);
            }
            finally
            {
                txtChange.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
