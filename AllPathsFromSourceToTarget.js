/**
 * @param {number[][]} graph
 * @return {number[][]}
 */
var allPathsSourceTarget = function(graph) {
    let g = new Graph(graph);
    
    return g.findAllPaths(0);
};

class Graph {
    constructor(graph) {
        if(graph && graph.length > 0) {
            this.nodes = graph;
            this.start = 0;
            this.end = graph.length-1;
        }
        else {
            this.nodes = [];
            this.start = null;
            this.end = null;
        }
    }

    findAllPaths(node) {
        if(node == this.nodes.length - 1) return [[node]];

        let result = [];

        if(this.nodes[node]) {
            this.nodes[node].forEach(n => {
                this.findAllPaths(n).forEach(path => {
                    result.push([node, ...path]);
                })
            });
        }
        
        return result;
    }
}