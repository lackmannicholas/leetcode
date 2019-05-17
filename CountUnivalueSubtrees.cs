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
    public int CountUnivalSubtrees(TreeNode root) {
        return uniSubtrees(root, 0);
    }
    
    private int uniSubtrees(TreeNode node, int count) {
        if(node == null)
            return count;
        
        bool uni = DFS(node, node.val);
        
        if(uni)
            count++;
        
        count = uniSubtrees(node.left, count);
        count = uniSubtrees(node.right, count);
        
        return count;
    }
    
    private bool DFS(TreeNode node, int val) {
        if(node == null)
            return true;
        
        if(node.left != null && node.left.val != val)
            return false;
        
        if(!DFS(node.left, val))
            return false;
        
        if(node.right != null && node.right.val != val)
            return false;
        
        if(!DFS(node.right, val))
            return false;
        
        return true;
    }
}
