public class Solution {
    public bool IsAnagram(string s, string t) {
        
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();

        foreach( char c in s )
        {
            if(dict1.ContainsKey(c))
            {
                dict1[c] +=1;
            }
            else
            {
                dict1[c] = 1;
            }
        }

        foreach( char c in t )
        {
            if(dict2.ContainsKey(c))
            {
                dict2[c] +=1;
            }
            else
            {
                dict2[c] = 1;
            }
        }

        if(dict1.Keys.Count() != dict2.Keys.Count()) return false;

        foreach( char c in dict1.Keys )
        {
            if(!dict2.ContainsKey(c))
            {
                return false;
            }
            if(dict1[c] != dict2[c])
            {
                return false;
            }
        }
        return true;
    }
}
