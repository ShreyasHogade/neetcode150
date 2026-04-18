public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length -1;
        while(i<j){
        while(i< j && !IsAlphaNum(s[i])) i++;

        while(i<j && !IsAlphaNum(s[j])) j--;

        if(char.ToLower(s[i]) != char.ToLower(s[j])) return false;

        i++;
        j--;
        }

        return true;
        
    }

    public bool IsAlphaNum(char c){
        return (c >= 'A'&& c <= 'Z' ||
                c >= 'a' && c<= 'z' ||
                c>='0' && c<='9');
    }
}
