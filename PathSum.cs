/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if(root != null && root.val == sum && (root.left != null || root.right != null))
            return false;
        
        return pathSum(root, sum, 0);
    }
    
    private bool pathSum(TreeNode node, int sum, int total) {
        if(node == null) return false;
        
        total += node.val;
        
        if(total == sum && node.left == null && node.right == null)
            return true;

        return pathSum(node.left, sum, total) || pathSum(node.right, sum, total);
    }
}
