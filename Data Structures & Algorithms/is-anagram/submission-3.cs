public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> c = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (c.ContainsKey(s[i])) {
                c[s[i]] = c[s[i]] + 1;
            } else {
                c.Add(s[i], 1);
            }

            if (c.ContainsKey(t[i])) {
                c[t[i]] = c[t[i]] - 1;
            } else {
                c.Add(t[i], -1);
            }
        }

        foreach (var v in c.Values) {
            if (v != 0)
                return false;
        }

        return true;
    }
}
