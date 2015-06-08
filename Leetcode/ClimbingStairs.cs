/*
You are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
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
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int[] steps = new int[n + 1];
            steps[0] = 0;
            steps[1] = 1;
            steps[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                steps[i] = steps[i - 1] + steps[i - 2];
            }

            return steps[n];
        }
    }
}
