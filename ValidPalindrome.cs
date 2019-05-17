public class Solution {
    public bool IsPalindrome(string s) {
        return isPalindrome(s);
    }
    
    private bool isPalindrome(string remainingString)  
    {
        int firstAlphaNum = 0;
        int lastAlphaNum = remainingString.Length-1;
        
        while(firstAlphaNum < lastAlphaNum){
            char c = remainingString[firstAlphaNum];
        
            // find first alphanum
            while(!Char.IsLetterOrDigit(c) && firstAlphaNum < remainingString.Length - 1){
                c = remainingString[++firstAlphaNum];
            }

            string first = Char.IsLetterOrDigit(c) ? c.ToString() : "";

            c = remainingString[lastAlphaNum];

            // find last alphanum
            while(!Char.IsLetterOrDigit(c) && lastAlphaNum > 0){
                c = remainingString[--lastAlphaNum];
            }

            string last = Char.IsLetterOrDigit(c) ? c.ToString() : "";
            
            if(first.ToLower() != last.ToLower()) {
                return false;
            }
            
            firstAlphaNum++;
            lastAlphaNum--;
        }
        
        return true;
    }
}
