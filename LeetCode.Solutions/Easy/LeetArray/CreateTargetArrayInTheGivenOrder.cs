using System;
using System.Collections.Generic;
using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetArray
{
    public class CreateTargetArrayInTheGivenOrder : IOperation
    {
        /*
         * Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
         * Output: [0,4,1,3,2]
         * Explanation:
         * nums       index     target
         * 0            0        [0]
         * 1            1        [0,1]
         * 2            2        [0,1,2]
         * 3            2        [0,1,3,2]
         * 4            1        [0,4,1,3,2]
         * 
         */
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputIntArray = new int[] { 0, 1, 2, 3, 4 };
            int[] index = new int[] { 0, 1, 2, 2, 1 };
            foreach (var item in CreateTargetArray(dataTypes.InputIntArray, index))
                Console.WriteLine(item);
        }

        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> arrayList = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                arrayList.Insert(index[i], nums[i]);
            }
            return arrayList.ToArray();
        }
    }
}
