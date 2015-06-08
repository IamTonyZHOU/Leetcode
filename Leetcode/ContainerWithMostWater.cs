/*
  Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

  Note: You may not slant the container.
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
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int area = 0;

            while (i != j)
            {
                int newArea = Math.Min(height[i], height[j]) * (j - i);
                area = newArea > area ? newArea : area;

                if (height[i] > height[j])
                    j--;
                else
                    i++;
            }

            return area;
        }
    }
}
