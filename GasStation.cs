public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = findStartPosition(gas, cost);

        // short-circuit for failure
        if(start == -1)
            return start;
        
        int position = -1;
        for(int i = start; i < gas.Length; i++){
            position = completeCurcuit(i, gas, cost);
            if(position != -1)
                return position;
        }
        
        return position;
    }
    
    private int findStartPosition(int[] gas, int[] cost){
        int start = -1;
        
        // find a starting position
        for(int i = 0; i < gas.Length; i++){
            // If we can't get enough gas from this station to get to the next,
            // we cannot start here
            if(gas[i] < cost[i]) continue;
            else {
                start = i;
                break; // we've found a potential starting position
            }
        }
        
        return start;
    }
    
    private int completeCurcuit(int start, int[] gas, int[] cost) {
        int tank = 0;
        
        // set up our starting position
        tank = gas[start];
        int nextStop = start + 1 == gas.Length ? 0 : start + 1;
        int thisStop = start;
        int i = 0;
        
        while (i < gas.Length) {
            // move to the next position
            tank -= cost[thisStop];
            
            // we've failed to get to the next stop
            if(tank < 0)
                return -1;
            
            tank += gas[nextStop];
            
            // maintain our indices
            nextStop = nextStop + 1 == gas.Length ? 0 : nextStop + 1;
            thisStop = thisStop + 1 == gas.Length ? 0 : thisStop + 1;
            i++;
        }
        
        return start;
    }
}
