using System;

namespace CodeWars.Solutions._6KYU
{
    /// <summary>
    /// This Kata can be found at : https://www.codewars.com/kata/554a44516729e4d80b000012
    /// </summary>
    public static class BuyingACar
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            int currentMonthCount = 0;
            int totalSavings = 0;
            double currentOldCarPrice = startPriceOld;
            double currentNewCarPrice = startPriceNew;
            double totalWorth = 0;

            if (startPriceOld >= startPriceNew)
            {
                return new int[2] { 0, startPriceOld - startPriceNew };
            }

            do
            {
                currentMonthCount++;
                totalSavings += savingPerMonth;

                if (currentMonthCount % 2 == 0)
                {
                    percentLossByMonth += .5;
                }

                currentOldCarPrice = currentOldCarPrice - (currentOldCarPrice * (percentLossByMonth / 100));
                currentNewCarPrice = currentNewCarPrice - (currentNewCarPrice * (percentLossByMonth / 100));
                totalWorth = totalSavings + currentOldCarPrice;
            }
            while (totalWorth < currentNewCarPrice);

            return new int[2] { currentMonthCount, Convert.ToInt32(totalWorth - currentNewCarPrice) };
        }
    }
}
