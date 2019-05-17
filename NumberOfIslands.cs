public class Solution {
    public int NumIslands(char[,] grid) {
        int count = 0;
        
        for(int x = 0; x <= grid.GetUpperBound(0); x++){
            for(int y = 0; y <= grid.GetUpperBound(1); y++){
                if(grid[x,y] == '1') {
                    count += 1;
                    DFS(grid, x, y);
                }
            }
        }
        
        return count;
    }
    
    private void DFS(char[,] grid, int x, int y) {
        if(x > grid.GetUpperBound(0) || 
           x < grid.GetLowerBound(0) || 
           y > grid.GetUpperBound(1) || 
           y < grid.GetLowerBound(1) || 
           grid[x,y] == '0') {
            return;
        }
        
        grid[x,y] = '0';
        
        DFS(grid, x+1, y);
        DFS(grid, x-1, y);
        DFS(grid, x, y+1);
        DFS(grid, x, y-1);
    }
}
