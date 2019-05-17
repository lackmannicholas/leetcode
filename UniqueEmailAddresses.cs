public class Solution {
    public int NumUniqueEmails(string[] emails) {
        cleanEmails(emails);
        return countUniqueEmails(emails);
    }
    
    private void cleanEmails(string[] emails) {
        for(int e = 0; e < emails.Length; e++) {
            string[] emailParts = emails[e].Split('@');
            
            // clean periods from local name
            string local = emailParts[0];
            
            // remove periods
            local = local.Replace(".", "");
            
            // get rid of anything after a +
            local = local.Split('+')[0];
            
            // rebuild cleaned email
            emails[e] = local + "@" + emailParts[1];
        }
    }
    
    private int countUniqueEmails(string[] emails) {
        Dictionary<string, int> unqiueEmails = new Dictionary<string, int>();
        
        for(int i = 0; i < emails.Length; i++) {
            int count = 0;
            if(unqiueEmails.TryGetValue(emails[i], out count))
                unqiueEmails[emails[i]]++;
            else
                unqiueEmails.Add(emails[i], 1);
        }
        
        return unqiueEmails.Count;
    }
}
