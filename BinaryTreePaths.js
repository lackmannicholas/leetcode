/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {string[]}
 */
var binaryTreePaths = function(root) {
    var bst = new BST(root);
    
    return bst.printTreePaths();
};

class BST {
    constructor(root = null){
        this.root = root;
    }

    printTreePaths = () => {
        let result = [];

        if(this.root)
            this.buildPath(this.root, "", result);

        return result;
    }

    buildPath = (node, path, result) => {
        path += node.val.toString() + "->";

        // we're at a left because we don't have a left or right child
        // add path and return
        if(!node.right && !node.left) {
            result.push(path.substring(0, path.length - 2));
            return;
        }

        // do we have a left child?
        if(node.left)
            this.buildPath(node.left, path, result);

        // do we have a right child?
        if(node.right)
            this.buildPath(node.right, path, result);

        return result;
    }
}