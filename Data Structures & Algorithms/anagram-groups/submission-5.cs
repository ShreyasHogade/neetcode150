public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramMap = new();

        //make the keys

        for(int i=0;i<strs.Length;i++){
            char[] chArr = strs[i].ToCharArray();
            Array.Sort(chArr);

            string str = new String(chArr);

            if(!anagramMap.ContainsKey(str)){
                anagramMap[str] = new List<string>();
            }
            anagramMap[str].Add(strs[i]);
            
        }

        //var res = new List<List<String>>(){};

        return anagramMap.Values.ToList();
    }
}
