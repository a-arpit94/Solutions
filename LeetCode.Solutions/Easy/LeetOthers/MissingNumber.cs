using Common.Setup;
using System;
using System.ComponentModel.DataAnnotations;
using LeetCode.Solutions.Easy.LeetMath;

namespace LeetCode.Solutions.Easy.LeetOthers
{
    public class MissingNumber : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new[] { 8, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(FindUsingMaths(dataTypes.InputIntArray));
        }

        public int FindMissingNumber(int[] nums)
        {
            int[] arr = new int[nums.Length + 1];
            foreach (var item in nums)
                arr[item] = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != -1)
                    return i;

            return -1;
        }

        //Sums of n integers = n(n+1)/2
        public int FindUsingMaths(int[] nums)
        {
            int max = int.MinValue, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                    max = nums[i];
                count += nums[i];
            }

            int total = (max * (max + 1) )/ 2;
            if (total == count)
                return max + 1;
            return total - count;
        }
    }
}
