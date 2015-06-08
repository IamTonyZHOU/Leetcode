/*
Given an array of integers, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2
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
        public Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            int length = numbers.Length;
            var numList = numbers.ToList();
            numList.Sort();

            int startIndex = 0;
            int endIndex = length - 1;

            for (int i = 0; i < length - 1; i++)
            {
                if (numList[startIndex] + numList[endIndex] > target)
                    endIndex--;
                else if (numList[startIndex] + numList[endIndex] < target)
                    startIndex++;
                else
                {
                    break;
                }
            }


            int returnStartIndex = Array.IndexOf(numbers, numList[startIndex]);
            int returnEndIndex = Array.LastIndexOf(numbers, numList[endIndex]);

            if (returnStartIndex > returnEndIndex)
            {
                var tmp = returnStartIndex;
                returnStartIndex = returnEndIndex;
                returnEndIndex = tmp;
            }

            return new Tuple<int, int>(returnStartIndex + 1, returnEndIndex + 1);
        }
    }
}
