/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var inorderTraversal = function(root) {
    let bst = new BST(root);
    
    
    return bst.InOrderTraversal();
};

class BST {
    constructor(root = null){
        this.root = root;
    }

    InOrderTraversal = () => {
        let result = [];

        if(this.root)
            this.inOrderTraversal(this.root, result);

        return result;
    }

    inOrderTraversal = (node, result) => {
        if(!node)
            return;

        this.inOrderTraversal(node.left, result);

        result.push(node.val);

        this.inOrderTraversal(node.right, result);

        return result;
    }
}
