public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach( var s in strs){
            // make a key according to the character in the string like for abc string
            // key will be "1,1,1,0,0....,(26th char)0"
            //convert all string to such format and check if key is present in the dict
            // if present add it to the value.

            int[] count = new int[26];
            foreach(char c in s){
                count[c-'a']++;
            }

            string key = string.Join(",",count);

            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }

            res[key].Add(s);

        }

        return res.Values.ToList<List<string>>();
    }
}
