public class Solution {
    public bool IsAnagram(string s, string t) {
        
        int[] KeyArr = new int[26];

        foreach(char ch in s){
            KeyArr[ch - 'a']++;
        }

        foreach(char ch in t){
            KeyArr[ch - 'a']--;
        }

        foreach(int i in KeyArr){
            if(i !=0) return false;
        }

        return true;
        
        /*if(s.Length != t.Length) return false;

        char[] arrS = s.ToCharArray();
        char[] arrT = t.ToCharArray();

        Array.Sort(arrS);
        Array.Sort(arrT);

        return new String(arrS) == new String(arrT);*/

    }
}
