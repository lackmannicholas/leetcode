public class Solution {
    public void ReverseString(char[] s) {
        if(s.Length < 2)
            return;
        
        int b = 0;
        int e = s.Length - 1;
        
        while(b <= (s.Length - 1) / 2 ){
            // get our values from both ends
            char bc = s[b];
            char ec = s[e];
            
            // swap values
            s[b] = ec;
            s[e] = bc;
            
            b++;
            e--;
        }
    }
}
