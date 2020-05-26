using LeetCode.Solutions.Setup;
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetArray
{
    public class Kids_With_the_Greatest_Number_of_Candies : IOperation
    {
        /*
         * Input: candies = [2,3,5,1,3], extraCandies = 3
         * Output: [true,true,true,false,true] 
         */

        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new int[] { 2, 3, 5, 1, 3 };
            foreach (var item in KidsWithCandies(dataTypes.InputIntArray, 3))
                Console.Write(item);
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>(candies.Length);
            int max = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                max = Math.Max(candies[i], max);
            }
            for (int i = 0; i < candies.Length; i++)
            {
                bool val = candies[i] + extraCandies >= max;
                result.Add(val);

            }

            return result;
        }
    }
}
