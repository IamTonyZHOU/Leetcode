using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*
    Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

    For example, given n = 3, a solution set is:

    "((()))", "(()())", "(())()", "()(())", "()()()"
    */

    public partial class Solution
    {
        private IList<string> result = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            if (n < 1)
                return null;

            CombineParenthesis(string.Empty, 0, 0, n);

            return result;
        }

        private void CombineParenthesis(string partString, int leftParenthesisNumber, int rightParenthesisNumber, int n)
        {
            if (leftParenthesisNumber == n && rightParenthesisNumber == n)
            {
                result.Add(partString);
            }
            else
            {
                if (leftParenthesisNumber < n)
                {
                    CombineParenthesis(partString + "(", leftParenthesisNumber + 1, rightParenthesisNumber, n);
                }


                if (rightParenthesisNumber < leftParenthesisNumber)
                {
                    CombineParenthesis(partString + ")", leftParenthesisNumber, rightParenthesisNumber + 1, n);
                }
            }

        }
    }
}
