using LeetCode.Solutions.Easy.LeetLinkedList;
using LeetCode.Solutions.GFG.LinkedList;
using LeetCode.Solutions.Setup;
using System;

namespace LeetCode.Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LeetCode!");

            IOperation operation = new Reverse_Linked_List();
            
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
            
            dataTypes.InputIntArray = new int[] { 7, 1, 5, 3, 6, 4 };
            dataTypes.InputStringArray = new String[] { "42", "     -42", "8390 in words", "converts to words 1234", "-91283472332" };
            dataTypes.listNode = null;
            return dataTypes;
        }

    }
}
