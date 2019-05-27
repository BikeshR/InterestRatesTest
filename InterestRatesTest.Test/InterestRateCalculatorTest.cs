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
            int[] balances = { 0, 999, 1000, 4999, 5000, 9999, 10000, 49999, 50000 };
            double[] interestRates = { 1, 1, 1.5, 1.5, 2, 2, 2.5, 2.5, 3 };

            for(int i = 0; i < balances.Length; i++)
            {
                double actual = InterestRateCalculator.GetInterestRate(balances[i]);

                Assert.AreEqual(interestRates[i], actual, "GetInterestRate returned a different value");
            }

        }
    }
}
