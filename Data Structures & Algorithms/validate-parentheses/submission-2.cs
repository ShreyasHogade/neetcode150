public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char>{
            {')', '('},
            {']', '['},
            {'}', '{'},
        };

        foreach(char c in s ){
            if(closeToOpen.ContainsKey(c)){
                if(st.Count > 0 && st.Peek() == closeToOpen[c]){
                    st.Pop();
                }else{
                    return false;
                }
            }
            else{
                st.Push(c);
            }
        }
        return st.Count == 0;
    }
}
