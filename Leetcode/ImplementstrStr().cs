/*
Implement strStr().

Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Update (2014-11-02):
The signature of the function had been updated to return the index instead of the pointer. If you still see your function signature returns a char * or String, please click the reload button  to reset your code definition.
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
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
                return 0;

            if (!string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
                return 0;

            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
                return -1;

            int index = -1;

            int[] next = Next(needle);
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    index = i;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (i + j < haystack.Length && haystack[i + j] == needle[j])
                        {
                            if (j == needle.Length - 1)
                                return index;

                            continue;
                        }
                        else
                        {
                            i += next[j];

                            index = -1;
                            break;
                        }
                    }


                }
            }

            if (index + needle.Length > haystack.Length)
                return -1;


            return index;
        }

        public static int[] Next(string str)
        {
            int length = str.Length;
            int[] next = new int[length];

            next[0] = 0;

            for (int i = 1; i < length; i++)
            {
                int k = next[i - 1];

                while (str[k] != str[i] && k != 0)
                {
                    k = next[k - 1];
                }

                if (str[i] == str[k])
                {
                    next[i] = k + 1;
                }
                else
                {
                    next[i] = 0;
                }
            }

            return next;
        }
    }
}
