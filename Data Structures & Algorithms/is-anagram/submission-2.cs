

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        List<char> sHash = new List<char>();
        List<char> tHash = new List<char>();

        for(int i = 0; i< s.Length;i++){
            sHash.Add(s[i]);
            tHash.Add(t[i]);
        }

        bool isEqual = sHash.OrderBy(x=>x).SequenceEqual(tHash.OrderBy(y=>y));

        if(!isEqual) return false;
        

        return true;

    }

}
