using System;
using System.Collections.Generic;
using System.Text;

namespace InterestRatesTest
{
    public static class InterestRateCalculator
    {
        public static double GetInterestRate(uint balance)
        {
            // £50,000+ - 3%
            if (balance >= 50000)
            {
                return 3;
            }
            // £10,000 - < £50,000 - 2.5% 
            else if (balance >= 10000)
            {
                return 2.5;
            }
            // £5,000 - < £10,000 - 2%
            else if (balance >= 5000)
            {
                return 2;
            }
            // £1,000 - < £5,000 - 1.5% 
            else if (balance >= 1000)
            {
                return 1.5;
            }
            // < £1,000 - 1%
            else
            {
                return 1;
            }
        }
    }
}
