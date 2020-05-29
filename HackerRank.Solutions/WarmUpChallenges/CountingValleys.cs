using Common.Setup;
using System;

namespace HackerRank.Solutions.WarmUpChallenges
{
    public class CountingValleys : IOperation
    {
        //NOT WORKING
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputString = "UDDDUDUU";
            Console.WriteLine(countingValleys(dataTypes.InputString));
        }
        private int countingValleys(string s)
        {
            int count = 0;
            if (s == null || s.Length < 3) return 0;

            for (int i = 0; i < s.Length - 3; i++)
            {
                if (s.Substring(i, 3) == "DDU")
                    count++;
            }

            return count;

        }
    }
}
