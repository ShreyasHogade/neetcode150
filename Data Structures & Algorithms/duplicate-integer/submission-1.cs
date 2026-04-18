public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> duplicate = new List<int>();

        foreach(int num in nums){
            if(duplicate.Contains(num)) return true;
            duplicate.Add(num);
        }

        return false;
    }
}