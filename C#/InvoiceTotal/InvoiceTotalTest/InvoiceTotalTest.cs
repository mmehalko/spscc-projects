using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTotalTest
{ [TestFixture]
    public class InvoiceTotalTest
    {
        [Test]
        public void GivenAnInvoiceCalculator_Reset_SetsAllValuesToZero()
        {
            //Arrange:
            var someInvoiceCalculator = new InvoiceTotal.InvoiceCalculator();
            someInvoiceCalculator.discountedAmount = 200;
            someInvoiceCalculator.invoiceTotal = 3;

            //Act:
            someInvoiceCalculator.Reset();

            // Assert:
            Assert.AreEqual(someInvoiceCalculator.discountedAmount, 0);
            Assert.AreEqual(someInvoiceCalculator.invoiceTotal, 0);
        }

        [TestCase(100, 24, 75)] // Should fail
        [TestCase(100, 25, 75)] // Should pass
        public void GivenAnInvoiceCalculator_Calculate_CalculatesCorrectly(decimal subtotal,
            decimal expDiscountedAmount, decimal expInvoiceTotal)
        {
            // Arrange:
            var someInvoiceCalculator = new InvoiceTotal.InvoiceCalculator();

            // Act:
            someInvoiceCalculator.Calculate(subtotal);

            // Assert:
            Assert.AreEqual(someInvoiceCalculator.discountedAmount, expDiscountedAmount, $"The expected discounted amount did not match: {someInvoiceCalculator.discountedAmount}.");
            Assert.AreEqual(someInvoiceCalculator.invoiceTotal, expInvoiceTotal, $"The expected invoice amount did not match: {someInvoiceCalculator.invoiceTotal}.");
        }
        [TestCase (100001)] // Should pass
        [TestCase (100)] // Should fail
        public void GivenAnInvoiceCalculator_WithInvalidAmount_CalculateShouldThrowException(decimal subtotal)
        {
            // Arrange:
            var someInvoiceCalculator = new InvoiceTotal.InvoiceCalculator();

            // Act & Assert:
            Assert.Throws<ArgumentException>(() => someInvoiceCalculator.Calculate(subtotal));
        }
    }
}
