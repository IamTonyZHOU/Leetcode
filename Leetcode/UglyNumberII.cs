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
        public int NthUglyNumber(int n)
        {
            if (n == 1) return 1;

            List<int> J = new List<int>(); // *2
            List<int> K = new List<int>(); // *3
            List<int> L = new List<int>(); // *5


            return 0;
        }
    }
}
