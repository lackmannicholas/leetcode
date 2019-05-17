public class Solution {
    Dictionary<string, string> lexicon = new Dictionary<string, string>();
    List<string> results = new List<string>();
    
    public IList<string> LetterCombinations(string digits) {
        // short circuit out if empty string
        if(string.IsNullOrEmpty(digits))
            return results;
        
        // build our digit mappings
        buildLexicon(lexicon);
        
        backtrack("", digits);
        return results;
    }
    
    private void backtrack(string combination, string nextDigits) {
        if(nextDigits.Length == 0) {
            results.Add(combination);
        }
        else {
            string digit = nextDigits.Substring(0,1);
            string letters = lexicon[digit];
            
            for(int i = 0; i < letters.Length; i++) {
                string letter = "";

                letter = letters.Substring(i, 1);

                backtrack(combination + letter, nextDigits.Substring(1));
            }
        }
    }
    
    private void buildLexicon(Dictionary<string, string> lex) {
        lex.Add("2","abc");
        lex.Add("3", "def");
        lex.Add("4", "ghi");
        lex.Add("5", "jkl");
        lex.Add("6", "mno");
        lex.Add("7", "pqrs");
        lex.Add("8", "tuv");
        lex.Add("9", "wxyz");
    }
}
