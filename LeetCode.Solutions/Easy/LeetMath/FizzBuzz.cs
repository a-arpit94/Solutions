using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetMath
{
    /*
     * Write a program that outputs the string representation of numbers from 1 to n.
       
       But for multiples of three it should output “Fizz” instead of the number 
       and for the multiples of five output “Buzz”.
       For numbers which are multiples of both three and five output “FizzBuzz”.
     */
    public class FizzBuzz : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.InputInt = 15;
            foreach (var i in fzList(dataTypes.InputInt))
            {
                Console.WriteLine(i);
            }
        }

        private IList<string> FzBzList(int n )
        {
            return FizzBuzzing(n).ToList();
        }

        private IEnumerable<string> FizzBuzzing(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 5 == 0) yield return "FizzBuzz";
                else if (i % 3 == 0) yield return "Fizz";
                else if (i % 5 == 0) yield return "Buzz";
                else yield return i.ToString();

                i++;

            }
        }

        //Cool Way
        private IList<string> fzList(int n)
        {
            IList<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string str = $"{(i%3==0?"Fuzz":"")}{(i%5==0?"Buzz":"")}";
                result.Add(str==""?i.ToString():str);
            }

            return result;
        }
    }
}
