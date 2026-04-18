public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        char[] arrS = s.ToCharArray();
        char[] arrT = t.ToCharArray();

        Array.Sort(arrS);
        Array.Sort(arrT);

        return new String(arrS) == new String(arrT);

    }
}
