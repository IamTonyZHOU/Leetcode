/*
Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the new length.
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
        public int RemoveDuplicates(int[] A)
        {
            int length = A.Length;

            if (length == 0)
                return 0;

            int i = 0;

            for (int index = 1; index < length; index++)
            {
                if (A[index] == A[i])
                {
                    continue;
                }
                else
                {
                    i++;
                    A[i] = A[index];
                }
            }

            return i + 1;
        }
    }
}
