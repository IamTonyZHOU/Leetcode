/*
Given a non-negative number represented as an array of digits, plus one to the number.

The digits are stored such that the most significant digit is at the head of the list.
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
        public int[] PlusOne(int[] digits)
        {
            bool carrybit = true;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (carrybit)
                {
                    digits[i] = digits[i] + 1;

                    if (digits[i] > 9)
                    {
                        digits[i] = 0;
                        carrybit = true;
                    }
                    else
                        carrybit = false;
                }
            }

            if (carrybit)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
            }

            return digits;
        }
    }
}
