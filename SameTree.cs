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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Queue<TreeNode> qP = new Queue<TreeNode>();
        Queue<TreeNode> qQ = new Queue<TreeNode>();
        
        if(qP == null || qQ == null)
            return false;
        
        qP.Enqueue(p);
        qQ.Enqueue(q);
        
        while(qP.Count != 0 && qQ.Count != 0){
            // grab next nodes in the list
            TreeNode pNode = qP.Dequeue();
            TreeNode qNode = qQ.Dequeue();
            
            // if they're both null, we're still good but nothing else to evaluate
            if(pNode == null && qNode == null)
                continue;
            
            // are the two nodes different?
            if((pNode == null && qNode != null) ||
               (pNode != null && qNode == null) ||
                pNode.val != qNode.val)
                return false;
            
            // Enqueue the children
            qP.Enqueue(pNode.left);
            qP.Enqueue(pNode.right);
            qQ.Enqueue(qNode.left);
            qQ.Enqueue(qNode.right);
        }
        
        if(qP.Count != 0 || qQ.Count != 0)
            return false;
        
        return true;
    }
}
