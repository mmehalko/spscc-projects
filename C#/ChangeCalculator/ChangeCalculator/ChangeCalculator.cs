using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    public class ChangeCalculator
    {
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int MIN = 0;
        const int MAX = 100;

        public int quartersCount { get; set; }
        public int dimesCount { get; set; }
        public int nickelsCount { get; set; }
        public int penniesCount { get; set; }

        public void Reset()
        {
            quartersCount = dimesCount = nickelsCount = penniesCount = 0;
        }

        public void Calculate(int amount)
        {       

            if (amount <= MAX && amount > MIN){
                quartersCount = (amount / QUARTERS);
                amount = amount % QUARTERS;

                dimesCount = (amount / DIMES);
                amount = amount % DIMES;

                nickelsCount = (amount / NICKELS);

                penniesCount = amount % NICKELS;
            }
            else
            { // If it doesn't meet the min/max requirements, read message.
                throw new ArgumentException($"{ amount } is not a valid entry between 1 and 100!");
            }
        }
    }
}
