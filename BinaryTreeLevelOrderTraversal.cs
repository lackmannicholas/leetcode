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
    public List<List<int>> LevelOrder(TreeNode root) {
        return BFS(root);
    }
    
    private List<List<int>> BFS(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        Queue<TreeNodeLevel> q = new Queue<TreeNodeLevel>();
        
        if(root == null) return result;
        
        TreeNodeLevel rootLevel = new TreeNodeLevel(root, 0);
        q.Enqueue(rootLevel);

        while(q.Count != 0) {
            TreeNodeLevel node = q.Dequeue();
            
            if(result.Count < node.level + 1)
                result.Add(new List<int>());
            
            result[node.level].Add(node.val);
            
            if(node.left != null)
                q.Enqueue(new TreeNodeLevel(node.left,node.level + 1));
                
            if(node.right != null)
                q.Enqueue(new TreeNodeLevel(node.right,node.level + 1));
        }
        
        return result;
    }
}

public class TreeNodeLevel : TreeNode
{
    public int level {get; set;}
    
    public TreeNodeLevel(TreeNode node, int level) : base(node.val)
    {
        this.level = level;
        this.val = node.val;
        this.left = node.left;
        this.right = node.right;
    }
}
