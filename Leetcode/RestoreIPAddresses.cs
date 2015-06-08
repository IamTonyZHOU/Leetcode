/*
    Given a string containing only digits, restore it by returning all possible valid IP address combinations.

     For example:
     Given "25525511135",

     return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
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
        private IList<string> results = new List<string>();

        public IList<string> RestoreIpAddresses(string s)
        {
            AnalyzeIpAddress(s, 0, string.Empty);

            return results;
        }

        private void AnalyzeIpAddress(string segement, int level, string prefix)
        {
            level++;
            if (level == 4)
            {
                if (IsValidIP(segement))
                    results.Add(prefix + "." + segement);

                return;
            }

            for (int i = 1; i <= 3; i++)
            {
                if (segement.Length < i)
                    continue;

                string singleIPField = segement.Substring(0, i);

                if (IsValidIP(singleIPField))
                {
                    //get the string after the singleIPField
                    int startIndex = segement.IndexOf(singleIPField) + singleIPField.Length;

                    string IPPrefix;
                    if (level == 1)
                        IPPrefix = singleIPField;
                    else
                        IPPrefix = prefix + "." + singleIPField;

                    AnalyzeIpAddress(segement.Substring(startIndex), level, IPPrefix);
                }
                else
                    return;

            }

        }

        private bool IsValidIP(string IPSegement)
        {
            if (string.IsNullOrEmpty(IPSegement))
                return false;

            if (IPSegement.Length > 3)
                return false;

            if (IPSegement.StartsWith("0") && int.Parse(IPSegement) >= 0 && IPSegement.Length > 1)
                return false;

            if (int.Parse(IPSegement) > 255)
                return false;

            return true;
        }
    }
}
