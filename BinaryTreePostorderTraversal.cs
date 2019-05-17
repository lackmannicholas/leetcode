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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        
        result = traversal(root, result);
        
        return result;
    }
    
    private List<int> traversal(TreeNode node, List<int> list){
        if(node == null)
            return list;
        
        if(node.left != null)
            traversal(node.left, list);
        
        if(node.right != null)
            traversal(node.right, list);
        
        list.Add(node.val);
        
        return list;
    }
}
