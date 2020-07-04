using Common.Setup;
using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy.LeetOthers
{
    public class ValidParentheses : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputString = "{[}]";
            Console.WriteLine(IsValid(dataTypes.InputString));
        }

        /*
         * Input: "([)]"
           Output: false
           Input: "{[]}"
           Output: true
         */

        private bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ctx in s.ToCharArray())
            {
                if (ctx == '(' || ctx == '{' || ctx == '[')
                    stack.Push(ctx);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    
                    var current = (char)(ctx == ']' || ctx == '}' ? ctx - 2 : ctx - 1);

                    if (current != stack.Peek()) 
                        return false;

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
