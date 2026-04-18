public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> AnaGrams = new Dictionary<string,List<string>>();

        foreach(string str in strs){
            var arr = str.ToCharArray();

            Array.Sort(arr);

            string key = new String(arr);

            if(!AnaGrams.ContainsKey(key)) 
                AnaGrams[key] = new List<string>();
            
            AnaGrams[key].Add(str);                
        }

        return AnaGrams.Values.ToList<List<string>>();
    }
}
