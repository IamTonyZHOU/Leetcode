/*
The count-and-say sequence is the sequence of integers beginning as follows:
1, 11, 21, 1211, 111221, ...

1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.
Given an integer n, generate the nth sequence.

Note: The sequence of integers will be represented as a string.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public partial class Solution
    {
        public String CountAndSay(int n)
        {
            if (n == 1) return "1";
            string currentNumber = "1";

            for (int i = 1; i < n; i++)
            {
                currentNumber = SayTheNumber(currentNumber);
            }

            return currentNumber;
        }

        private string SayTheNumber(string strN)
        {
            string output = string.Empty;
            int numberCount = 0;
            char previousChar = ' ';
            char currentChar;

            for (int i = 0; i < strN.Length; i++)
            {
                currentChar = strN[i];

                if (previousChar != currentChar)
                {
                    if (previousChar != ' ')
                        output += numberCount.ToString() + previousChar.ToString();

                    numberCount = 1;
                    previousChar = currentChar;

                }
                else
                {
                    numberCount++;
                }

                if (i == strN.Length - 1)
                    output += numberCount.ToString() + previousChar.ToString();
            }

            return output;
        }
    }
}
