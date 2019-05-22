using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTotal
{
    public class InvoiceCalculator
    {
        public const decimal DISCOUNTPERCENT = .25m;
        const int MAX = 10000;
        const int MIN = 0;

        public decimal discountedAmount { get; set; }
        public decimal invoiceTotal { get; set; }

        public void Reset()
        {
            discountedAmount = 0;
            invoiceTotal = 0;
        }

        public void Calculate(decimal subtotal)
        {
            

            if (subtotal >= MIN && subtotal <= MAX)
            {
                discountedAmount = subtotal * DISCOUNTPERCENT;
                invoiceTotal = subtotal - discountedAmount;

                discountedAmount = Math.Round(discountedAmount, 2);
                invoiceTotal = Math.Round(invoiceTotal, 2);
            }
            else
            {
                throw new ArgumentException($"{subtotal} is not a valid entry between {MIN} - {MAX}");
            }
        }
    }
}
