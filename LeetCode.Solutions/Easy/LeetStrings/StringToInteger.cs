using Common.Setup;
using System;

namespace LeetCode.Solutions.Easy.LeetStrings
{
    public class StringToInteger : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputStringArray = new String[] { "42", "     -42", "8390 in words", "converts to words 1234", "-91283472332" };
            //Output - 42, -42, 8390, 0, -2147483648
            //foreach (var str in dataTypes.InputStringArray)
            Console.WriteLine(MyAtoi(dataTypes.InputStringArray[0]));
        }

        public int MyAtoi(string str)
        {
            int val = 0, i = 0;
            str = str.Trim();
            if (str[0] < '0' || str[0] > '9')
                if (str[0] != '-')
                    return 0;
            if (str[0] == '-')
            {
                i = 1;
            }

            for (; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    val = val * 10 + str[i];
                }
                else
                    break;

            }
            return val;

        }

        public bool checkValidity(string str, int index)
        {
            if (str[index] != null && (str[index] >= '0' && str[index] <= '9') || (str[index] == '+' || str[index] == '-'))
            {
                return true;
            }
            return false;
        }
    }
}
