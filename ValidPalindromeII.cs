public class Solution {
    public bool ValidPalindrome(string s) {
        // have we skipped a letter?
        bool skipped = false;
        
        int firstAlphaNum = 0;
        int lastAlphaNum = s.Length-1;
        
        while(firstAlphaNum < lastAlphaNum){
            string first = s.Substring(firstAlphaNum,1);
            string last = s.Substring(lastAlphaNum, 1);
            
            if(first != last && skipped) {
                return false;
            }
            else if(first != last && !skipped) {// if we haven't skipped a letter yet then skip it
                if(lastAlphaNum-firstAlphaNum == 1) return true;
                
                // find which one is wrong
                if (first == s.Substring(lastAlphaNum-1,1) && s.Substring(firstAlphaNum+1,1) == last){
                    // do nothing
                    firstAlphaNum++;
                    lastAlphaNum--;
                    continue;
                }
                else if(first == s.Substring(lastAlphaNum-1,1))
                    lastAlphaNum--;
                else if(s.Substring(firstAlphaNum+1,1) == last)
                    firstAlphaNum++;
                else
                    return false;

                skipped = true;
            }
            firstAlphaNum++;
            lastAlphaNum--;
        }
        
        return true;
    }
}
