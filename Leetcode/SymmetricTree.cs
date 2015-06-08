/*
Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

For example, this binary tree is symmetric:

    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following is not:
    1
   / \
  2   2
   \   \
   3    3
Note:
Bonus points if you could solve it both recursively and iteratively.

confused what "{1,#,2,3}" means? > read more on how binary tree is serialized on OJ.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public partial class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            if (root.left == null && root.right != null)
                return false;

            if (root.left != null && root.right == null)
                return false;

            ShiftNode(root.left);
            return IsSameTree(root.left, root.right);
        }

        private void ShiftNode(TreeNode node)
        {
            if (node == null)
                return;

            //if (left == null && right != null || left != null && right == null)
            //    return;

            if (node.right == null && node.left != null)
            {
                node.right = node.left;
                node.left = null;
                ShiftNode(node.right);
                return;
            }

            if (node.left == null && node.right != null)
            {
                node.left = node.right;
                node.right = null;
                ShiftNode(node.left);
                return;
            }

            if (node.left != null && node.right != null)
            {
                TreeNode nodetmp = node.left;
                node.left = node.right;
                node.right = nodetmp;

                ShiftNode(node.left);
                ShiftNode(node.right);

                return;
            }

            if (node.left == null && node.right == null)
                return;
        }


        private bool IsSameTree(TreeNode p, TreeNode q)
        {
            return LDR(p, q);
        }

        private bool LDR(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null && q != null || p != null && q == null)
                return false;


            bool l = LDR(p.left, q.left);

            //LDR(p, q);
            if (p.val != q.val)
                return false;

            bool r = LDR(p.right, q.right);

            return l & r;
        }
    }
}
