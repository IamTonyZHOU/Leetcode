﻿/*
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2. The number of elements initialized in nums1 and nums2 are m and n respectively.
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
        public void Merge(int[] A, int m, int[] B, int n)
        {
            int APointer = m - 1;
            int BPointer = n - 1;

            for (int i = m + n - 1; i >= 0; i--)
            {
                if (APointer < 0)
                {
                    A[i] = B[BPointer];
                    BPointer--;
                    continue;
                }
                else if (BPointer < 0)
                {
                    A[i] = A[APointer];
                    APointer--;
                    continue;
                }


                if (A[APointer] >= B[BPointer])
                {
                    A[i] = A[APointer];
                    APointer--;
                }
                else
                {
                    A[i] = B[BPointer];
                    BPointer--;
                }

            }
        }
    }
}
