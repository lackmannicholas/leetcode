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
    public int RangeSumBST(TreeNode root, int L, int R) {
        return calcRangeSum(root, L, R, 0);
    }
    
    private int calcRangeSum(TreeNode node, int L, int R, int result){
        if(node == null)
            return result;
        
        if(node.val <= R && node.val >= L)
            result += node.val;
        
        if(node.val < R)
            result = calcRangeSum(node.right, L, R, result);
        
        if(node.val > L)
            result = calcRangeSum(node.left, L, R, result);
        
        return result;
    }
}
