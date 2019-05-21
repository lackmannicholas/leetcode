public class Solution {
    
    public int NumJewelsInStones(string J, string S) {
        HashSet<char> jewels = new HashSet<char>();
        buildJewelSet(J, jewels);
        return countJewels(S, jewels);
    }
    
    // create a set of jewels as a O(1) lookup
    private void buildJewelSet(string j, HashSet<char> jewels){
        for(int i = 0; i < j.Length; i++) {
            jewels.Add(j[i]);
        }
    }
    
    // Go through all stones, and if they are a jewel, increase the count O(S.Length)
    private int countJewels(string S, HashSet<char> jewels){
        int count = 0;
        for(int s = 0; s < S.Length; s++) {
            if(jewels.Contains(S[s]))
                count++;
        }
        
        return count;
    }
}
