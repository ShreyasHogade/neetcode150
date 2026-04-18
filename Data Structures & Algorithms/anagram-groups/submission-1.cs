public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach( var s in strs){
            char[] charA = s.ToCharArray();
            //sort the array as anagrams after sorting are the same 
            Array.Sort(charA);

            string sortedS = new string(charA);

            if(!res.ContainsKey(sortedS)){
                res[sortedS] = new List<string>();
            }

            res[sortedS].Add(s);

        }

        return res.Values.ToList<List<string>>();
    }
}
