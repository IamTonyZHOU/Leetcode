/*
Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

Solve it without division and in O(n).

For example, given [1,2,3,4], return [24,12,8,6].
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
        public int[] ProductExceptSelf(int[] nums)
        {
            // set default value to 1
            int[] res = Enumerable.Repeat(1, nums.Length).ToArray();

            //first loop, res[i] is the product from 0 to i-1
            for (int i=1;i<nums.Length;i++)
            {
                res[i] = res[i - 1] * nums[i-1];
            }

            int rightValue = 1;
            //second loop, res[i] is res[i] * product of right values
            for (int i=nums.Length-1; i>=0; i--)
            {
                res[i] = res[i] * rightValue;
                rightValue = nums[i] * rightValue;
            }

            return res;
        }
    }
}
