/*
Given two binary strings, return their sum (also a binary string).

For example,
a = "11"
b = "1"
Return "100".
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
        public string AddBinary(string a, string b)
        {
            a = new String(a.Reverse().ToArray<char>());
            b = new String(b.Reverse().ToArray<char>());

            int lengthOfA = a.Length;
            int lengthOfB = b.Length;

            int longer = lengthOfA > lengthOfB ? lengthOfA : lengthOfB;
            int shroter = longer == lengthOfA ? lengthOfB : lengthOfA;

            bool carryBit = false;

            string output = string.Empty;


            for (int i = 0; i < longer; i++)
            {
                int sum = 0;
                if (i < a.Length && i < b.Length)
                    sum = (a[i] - '0') + (b[i] - '0');
                else if (i >= a.Length)
                    sum = b[i] - '0';
                else if (i >= b.Length)
                    sum = a[i] - '0';

                if (carryBit)
                    sum++;

                if (sum / 2 > 0)
                    carryBit = true;
                else
                    carryBit = false;

                output += sum % 2;

            }

            if (carryBit)
                output += "1";

            return new String(output.Reverse().ToArray<char>());
        }
    }
}
