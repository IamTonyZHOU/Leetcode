/*
Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

If the last word does not exist, return 0.

Note: A word is defined as a character sequence consists of non-space characters only.

For example, 
Given s = "Hello World",
return 5.
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
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int lastIndex = s.LastIndexOf(' ');

            if (lastIndex == -1)
                return s.Length;

            return s.Substring(lastIndex).Length - 1;
        }
    }
}
