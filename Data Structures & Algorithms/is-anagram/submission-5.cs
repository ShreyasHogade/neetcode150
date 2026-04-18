public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        List<char> sHash = new List<char>(s);
        List<char> tHash = new List<char>(t);

        bool isEqual = sHash.OrderBy(x=>x).SequenceEqual(tHash.OrderBy(y=> y));

        return isEqual;

    }
}
