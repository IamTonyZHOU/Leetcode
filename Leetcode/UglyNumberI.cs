/*
Write a program to check whether a given number is an ugly number.

Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 6, 8 are ugly while 14 is not ugly since it includes another prime factor 7.

Note that 1 is typically treated as an ugly number.
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
        public bool IsUgly(int num)
        {
            if (num < 0)
                return false;

            if (num ==1 )
                return true;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    continue;
                }

                if (num % 3 == 0)
                {
                    num = num / 3;
                    continue;
                }

                if (num % 5 == 0)
                {
                    num = num / 5;
                    continue;
                }

                if (num == 1)
                    return true;
                else
                    return false;

            }

            return false;

        }
    }
}
