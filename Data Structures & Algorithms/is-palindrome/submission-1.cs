public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();

        string newStr = "";

        for(int i=0; i<s.Length; i++)
        {
            if( (s[i] <= 'z' && s[i] >= 'a') 
            || (s[i] >= '0' && s[i] <= '9' ) )
            {
                newStr += s[i];
            }
        }

        int p1 = 0;
        int p2 = newStr.Length-1;
        while( p1 <= p2 )
        {
            if( newStr[p1] != newStr[p2] ) 
            {
                return false;
            }
            p1++;
            p2--;
        }

        return true;
    }
}
