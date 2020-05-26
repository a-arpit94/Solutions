using LeetCode.Solutions.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetArray
{
    public class Best_Time_to_Buy_and_Sell_Stock : IOperation
    {

        /*  Input: [7,1,5,3,6,4]
*  Output: 5
*  Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
*  Not 7-1 = 6, as selling price needs to be larger than buying price.
*/

        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new int[] { 7, 3, 5, 6, 2, 4 };
            Console.WriteLine(maxProfit(dataTypes.InputIntArray));
        }

        public int maxProfit(int[] prices)
        {
            int size = prices.Length;
            int maxProfit = 0;
            int minValue = int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                minValue = Math.Min(minValue, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minValue);
            }

            return maxProfit;
        }
    }
}
