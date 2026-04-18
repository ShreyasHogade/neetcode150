public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> freq = new();
        if(nums.Length <=1) return false;
        for(int i=0;i<nums.Length;i++){
            if(freq.ContainsKey(nums[i])) return true;

            freq[nums[i]] = 1;
        }
        return false;
    }
}