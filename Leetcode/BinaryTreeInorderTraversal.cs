using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*
    Given a binary tree, return the inorder traversal of its nodes' values.

    For example:
    Given binary tree {1,#,2,3},
       1
        \
         2
        /
       3
    return [1,3,2].

    Note: Recursive solution is trivial, could you do it iteratively?*/

    /**
    * Definition for binary tree
    */
      public class TreeNode {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
      }
 
    public partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> result = new List<int>();

            TreeNode p = root;

            while (p != null || stack.Any())
            {
                while (p != null) //handle the left node
                {
                    stack.Push(p);
                    p = p.left;
                }

                if (stack.Any())
                {
                    p = stack.Pop();
                    result.Add(p.val);
                    p = p.right;
                }

            }

            return result;
        }
    }
}
