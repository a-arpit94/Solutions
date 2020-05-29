using Common.Setup;
using System;
using System.Collections.Generic;

namespace HackerRank.Solutions.WarmUpChallenges
{
    public class SockMerchant : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(findPairs(dataTypes.InputIntArray));
        }
        /*
         * For example, there are n =9 socks with colors arr = [10, 20, 20, 10, 10, 30, 50, 10, 20].
         * There is one pair of color 20 and two of color 10. There are three odd socks left, one of each color. The number of pairs is 3.
         */

        private int findPairs(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);
                dict[arr[i]]++;
            }

            int count = 0;
            foreach (var value in dict.Values)
            {
                count += value / 2;
            }
            return count;
        }
    }
}
