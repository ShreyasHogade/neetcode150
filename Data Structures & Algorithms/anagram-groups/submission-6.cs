public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        //Approach 1: when input is large and smallercase string
        // make the keys based on frequency of char occurence.
        Dictionary<string, List<string>> res = new();
        
        foreach(string str in strs){
             var arr = new int[26];
            
             foreach(char c in str){
                arr[c-'a']++;
             }

             string key = string.Join("#",arr);

             if(!res.ContainsKey(key)){
                res[key] = new List<string>();
             }

             res[key].Add(str);

        }

        return res.Values.ToList<List<string>>();


        
        
        /* Approach 2: when unicode strings are present
        
        Dictionary<string, List<string>> anagramMap = new();

        //make the keys by sorting the strings

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

        */
    }
}
