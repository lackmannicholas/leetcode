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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> preOrder = new List<int>();
        
        if(root == null)
            return preOrder;
        
        return getPreOrder(preOrder, root);
    }
    
    public IList<int> getPreOrder(IList<int> list, TreeNode node) {
        //list.Add(node.val);
        
        TreeNode subTree = node;
        TreeNode prev = node;

        while(subTree != null) {
            list.Add(subTree.val);
            
            if(subTree.left != null)
                subTree = subTree.left;
            
            else if (subTree.right != null)
                subTree = subTree.right;
            
            else if(subTree.left == null && subTree.right == null)
                subTree = prev;
            
        }
        
        return list;
    }
}
