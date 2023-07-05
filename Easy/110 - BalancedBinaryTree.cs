/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root == null)
        {
            return true;
        }

        var leftHeight = GetHeight(root.left);
        var rightHeight = GetHeight(root.right);
        
        if(Math.Abs(leftHeight - rightHeight) > 1)
        {
            return false;
        }

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int GetHeight(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        if(root.left == null && root.right == null)
        {
            return 1;
        }

        if(root.left != null && root.right == null)
        {
            return GetHeight(root.left) + 1;
        }

        if(root.left == null && root.right != null)
        {
            return GetHeight(root.right) + 1;
        }

        return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
    }
}
