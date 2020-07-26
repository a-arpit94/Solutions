using Common.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetDP
{
    public class ClimbingStairs : IOperation

    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputInt = 0;
            int[] arr = new int[46];
            for (int i = dataTypes.InputInt; i <= 45; i++)
            {
                arr[i] = ClimbStairs(i);
                Console.WriteLine(i);
            }
            
        }

        public int ClimbStairs(int n)
        {
            int ones, twos;
            double sum = 0;
            if (n == 0) return 0;
            //if (n == 39) return 102334155;
            for (twos = 0; twos <= n / 2; twos++)  // 21*40*38*36.....*2*
            {
                ones = n - 2 * twos;
               sum += fact(ones + twos) / fact(ones) / fact(twos);
            }

            return (int)Math.Round(sum);

        }

        private double fact(int n)
        {

            if (n == 0)
                return 1;

            return n * fact(n - 1);
        }

        private int xyz(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;

            var previous = 1;
            var previousPrevious = 1;
            var current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = previous + previousPrevious;

                // reset
                previousPrevious = previous;
                previous = current;
            }

            return current;
        }
    }
}
