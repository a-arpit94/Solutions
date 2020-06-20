using System;
using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetMath
{
    public class PowerOfThree : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputInt = 27;
            Console.WriteLine(IsPowerOfThreeWithoutLooping(dataTypes.InputInt));
        }

        //Time complexity - O(log n base 3)
        private bool IsPowerOfThreeWithLooping(int n)
        {
            if (n < 1) return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }

        // Follow up question- without looping/recursion
        //https://leetcode.com/articles/power-of-three/
        //Time complexity - O(1)
        private bool IsPowerOfThreeWithoutLooping(int n)
        {
            // Highest power of 3 that lies within int range is 1162261467
            // So any power of 3 should be a factor of above number.
            return n > 0 && 1162261467 % n == 0;
        }
    }
}
