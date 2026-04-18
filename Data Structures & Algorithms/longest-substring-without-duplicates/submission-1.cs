public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> charSet =  new HashSet<char>();

        int l,r,res;
        l=r=res=0;

        for(r =0;r<s.Length;r++){

            while(charSet.Contains(s[r])){
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, r-l+1);

        }
        return res;
    }
}
