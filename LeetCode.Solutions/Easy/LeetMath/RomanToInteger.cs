using System;
using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetMath
{
    public class RomanToInteger : IOperation
    {
        /* Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
         *
         * I  can be placed before V (5) and X (10) to make 4 and 9.
         * X can be placed before L (50) and C (100) to make 40 and 90.
         * C can be placed before D (500) and M (1000) to make 400 and 900
         *
         */
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputString = "MCMXCIV"; //2014

            Console.WriteLine(RomanToInt(dataTypes.InputString));
        }

        public int RomanToInt(string s)
        {
            int result = 0, i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                    result += i + 1 != s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X') ? -1 * 1 : 1;
                else if (s[i] == 'V')
                    result += 5;
                else if (s[i] == 'X')
                    result += i + 1 != s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C') ? -1 * 10 : 10;
                else if (s[i] == 'L')
                    result += 50;
                else if (s[i] == 'C')
                    result += i + 1 != s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M') ? -1 * 100 : 100;
                else if (s[i] == 'D')
                    result += 500;
                else if (s[i] == 'M')
                    result += 1000;

            }

            return result;
        }
    }
}
