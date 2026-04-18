public class Solution {
    public bool IsAnagram(string s, string t) {
/// to work the solution with any character 


if (s.Length != t.Length)
        return false;

    Dictionary<char, int> map = new Dictionary<char, int>();

    foreach(char c in s){
        if(!map.ContainsKey(c)) map[c]=0;

        map[c]++;
    }

    foreach(char c in t){
        if(!map.ContainsKey(c)) return false;

        map[c]--;

        if(map[c]<0) return false;
    }

    return true;

    // 1st Solution

        
        /*int[] KeyArr = new int[26];

        foreach(char ch in s){
            KeyArr[ch - 'a']++;
        }

        foreach(char ch in t){
            KeyArr[ch - 'a']--;
        }
//instead of two loops we can do 
//  for(int i =0;i<s.Length;i++){
           KeyArr[s[i]- 'a] ++;
           KeyArr[t[i] - 'a]--;
            }
        foreach(int i in KeyArr){
            if(i !=0) return false;
        }

        return true;
       //solution 2: 
        /*if(s.Length != t.Length) return false;

        char[] arrS = s.ToCharArray();
        char[] arrT = t.ToCharArray();

        Array.Sort(arrS);
        Array.Sort(arrT);

        return new String(arrS) == new String(arrT);*/

    }
}
