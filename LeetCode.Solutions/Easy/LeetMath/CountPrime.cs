using Common.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetMath
{
    public class CountPrime : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputInt = 2;
            Console.WriteLine(CountPrimes(dataTypes.InputInt));
        }

        //Sieve of Eratosthenes Algo 
        // Complexity O(n log log n)
        /* https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#Algorithm_complexity */

        public int CountPrimes(int n)
        {
            bool[] arr = new bool[n + 1];
            for (var item = 2;item<arr.Length; item++)
                arr[item] = true;
            for (int i = 2; i * i < arr.Length; i++)
            {
                if (arr[i])
                {
                    int k = i * i;
                    while (k < arr.Length)
                    {
                        arr[k] = false;
                        k = k + i;
                    }
                }
            }

            int count = 0;
            foreach (var item in arr)
                if (item)
                    count++;
            
            return count;
        }
    }
}
