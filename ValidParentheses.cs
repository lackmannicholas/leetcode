public class Solution {
    private Stack<Char> stack = new Stack<Char>();
    private Dictionary<char, char> dic = new Dictionary<char, char>();
    
    public bool IsValid(string s) {
        dic.Add(')', '(');
        dic.Add(']', '[');
        dic.Add('}', '{');
        
        for(int i = 0; i < s.Length; i++) {
            var sub = s[i];
            if(dic.ContainsKey(sub)) {
                if(stack.Count > 0 && match(stack.Peek(), sub))
                    stack.Pop();
                else
                    return false;
            }
            else if(dic.ContainsValue(sub))
                stack.Push(sub);
        }
        return stack.Count == 0;
    }
    
    private bool match(char last, char next) {
        if(dic[next] == last)
            return true;
        return false;
    }
}
