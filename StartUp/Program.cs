using Common.Setup;
using System;
using LeetCode.Solutions.Easy.LeetLinkedList;
using GeeksForGeeks.Solutions;
using GeeksForGeeks.Solutions.LinkedList;
using HackerRank.Solutions.WarmUpChallenges;
using LeetCode.Solutions.Easy.LeetDP;
using LeetCode.Solutions.Easy.LeetMath;
using LeetCode.Solutions.Easy.LeetTrees;

namespace StartUp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello LeetCode!");
            IOperation operation = new RomanToInteger();

            CallMethod(operation);
        }

        private static void CallMethod(IOperation operation)
        {
            var setInput = SetAllDataTypes();
            operation.Execute(setInput);
        }

        private static DataTypes SetAllDataTypes()
        {
            DataTypes dataTypes = new DataTypes();

            dataTypes.InputInt = 2;
            dataTypes.InputIntArray = new[] { 7, 1, 5, 3, 6, 4 };
            dataTypes.InputString = "Arpit";
            dataTypes.InputStringArray = new[] { "42", "     -42", "8390 in words", "converts to words 1234", "-91283472332" };
            dataTypes.listNode = null;
            dataTypes.InputTree = null;
            return dataTypes;
        }

    }
}
