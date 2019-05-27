using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using InterestRatesTest;

namespace InterestRatesTest.Test
{
    [TestFixture]
    public class InterestRateCalculatorTest
    {
        [Test]
        public void TestGetInterestRate()
        {
            // Lower and upper bounds of each band of balance and their respective expected interest rate.
            int[] balances = { 1, 999, 1000, 4999, 5000, 9999, 10000, 49999, 50000 };
            double[] interestRates = { 1, 1, 1.5, 1.5, 2, 2, 2.5, 2.5, 3 };

            // Loop tests through all the test values.
            for(int i = 0; i < balances.Length; i++)
            {
                double actual = InterestRateCalculator.GetInterestRate(balances[i]);

                Assert.AreEqual(interestRates[i], actual, "GetInterestRate returned a different value");
            }

        }
    }
}
