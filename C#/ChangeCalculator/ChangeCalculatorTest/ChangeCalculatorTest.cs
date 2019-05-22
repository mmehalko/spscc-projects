using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{ [TestFixture]
    public class ChangeCalculatorTest
    {
        [Test]
        public void GivingAChangeCalculator_Reset_SetsAllValuesToZero()
        {
            // 3 Parts that make up unit test. Arrange, Act, Assert.
            // Arrange: Set object up to operate against it.
            // Act: Do operation. Capture results.
            // Assert: Evaluate expected result against actual results.

            // Arrange. Create new object and set property values.
            var someChangeCalculator = new ChangeCalculator();
            someChangeCalculator.quartersCount = 3;
            someChangeCalculator.penniesCount = 2;
            someChangeCalculator.dimesCount = 8;
            someChangeCalculator.nickelsCount = 0;

            // Act
            someChangeCalculator.Reset();

            // Assert  
            Assert.AreEqual(someChangeCalculator.quartersCount, 0);
            Assert.AreEqual(someChangeCalculator.dimesCount, 0);
            Assert.AreEqual(someChangeCalculator.nickelsCount, 0);
            Assert.AreEqual(someChangeCalculator.penniesCount, 0);

        }
        [TestCase (21, 0, 2, 0, 1)]
        [TestCase (10, 0, 0, 0, 10)]
        [TestCase (25, 1, 0, 0, 0)]
        public void GivenAChangeCalculator_Calculate_CalculatesCorrectly(int amount, int expQuartersCount, int expDimesCount, int expNicklesCount, int expPenniesCount)
        {
            // Define test cases. Give array of test to opporate against with same logic
            // Arrange:
            var someChangeCalculator = new ChangeCalculator();

            // Act:
            someChangeCalculator.Calculate(amount);

            // Asset:
            Assert.AreEqual(someChangeCalculator.quartersCount, expQuartersCount, $"Quarter amounts did not match: {someChangeCalculator.quartersCount}.");
            Assert.AreEqual(someChangeCalculator.dimesCount, expDimesCount, $"Dimes amounts did not match: {someChangeCalculator.dimesCount}.");
            Assert.AreEqual(someChangeCalculator.nickelsCount, expNicklesCount, $"Nickels amounts did not match: {someChangeCalculator.nickelsCount}.");
            Assert.AreEqual(someChangeCalculator.penniesCount, expPenniesCount, $"Pennies amounts did not match: {someChangeCalculator.penniesCount}.");

        }

        [TestCase (101)]
        [TestCase(28)]
        [TestCase(0)]
        public void GivenAChangeCalculator_WithInvalidAmount_CalculateShouldThrowException(int amount)
        {
            // Arange:
            var someChangeCalculator = new ChangeCalculator();

            // Act:
            // someChangeCalculator.Calculate(amount);

            // Asset:
            Assert.Throws<ArgumentException>(() => someChangeCalculator.Calculate(amount));
        }

    }
}
