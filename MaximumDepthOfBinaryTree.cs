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
    public int MaxDepth(TreeNode root) {
        return maxDepth(root);
    }
    
    private int maxDepth(TreeNode node) {
        if(node == null) return 0;
        
        int left = maxDepth(node.left);
        int right = maxDepth(node.right);
        
        return Math.Max(left, right) + 1;
    }
}
