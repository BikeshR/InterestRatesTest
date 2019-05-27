using System;

namespace InterestRatesTest
{
    class Program
    {
        static void Main()
        {
            // So that it can be reused.
            while(true)
            {
                Console.Write("Enter you balance: ");
                string balance = Console.ReadLine();

                try
                {
                    // uint because balance would be > 0. Still return 1% for 0 though.
                    uint balanceInt = Convert.ToUInt32(balance);
                    double interest = InterestRateCalculator.GetInterestRate(balanceInt);
                    Console.WriteLine("Interest rate for £{0}: {1}%", balanceInt, interest);
                }
                catch
                {
                    Console.WriteLine("Write a valid balance.");
                }
            }
        }
    }
}
