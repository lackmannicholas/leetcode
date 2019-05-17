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
    public bool IsSymmetric(TreeNode root) {
        Stack<string> values = new Stack<string>();
        
        if(root == null) return true;
        
        leftSide(root.left, values);
        rightSide(root.right, values);
        
        return values.Count == 0;
    }
    
    private Stack<string> leftSide(TreeNode node, Stack<string> values) {
        values.Push(node == null ? null : node.val.ToString());
        
        if(node == null)
            return values;
        
        leftSide(node.left, values);
        leftSide(node.right, values);
        
        return values;
    }
    
    private Stack<string> rightSide(TreeNode node, Stack<string> values) {
        if(node == null) {
            if(values.Count > 0 && values.Peek() == null)
                values.Pop();
            return values;
        }
            
        rightSide(node.left, values);
        rightSide(node.right, values);
        
        if(values.Count > 0 && values.Peek() == node.val.ToString())
            values.Pop();
        else if (values.Count > 0 && values.Peek() != node.val.ToString())
            values.Push(node.val.ToString());
        else if (values.Count == 0)
            values.Push(node.val.ToString());
        
        return values;
    }
}
