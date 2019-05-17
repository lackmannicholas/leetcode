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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        
        traversal(root, result);
        
        return result;
    }
    
    public List<int> traversal(TreeNode node, List<int> list) {
        if(node == null)
            return list;
        
        if(node.left != null)
            traversal(node.left, list);
        
        list.Add(node.val);
        
        if(node.right != null)
            traversal(node.right, list);
        
        return list;
    }
}
