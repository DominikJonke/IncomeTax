using System;

namespace IncomeTax
{
    public static class Tax
    {
        public static double QueryTax()
        {
            double input = 0;
            double taxSum = 0;

            Console.WriteLine("Your income: ");
            input = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (input > 60000)
                {
                    taxSum = (input - 60000) * 0.5;
                }
                else if (input > 25000)
                {
                    taxSum += (input - 25000) * 0.43214286;
                }
                else if (input > 11000)
                {
                    taxSum += (input - 11000) * 0.365;
                }
            } while (taxSum >= 11000);

            return taxSum;
        }
    }
}
