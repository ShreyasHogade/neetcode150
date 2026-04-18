public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> res = new();
        if(nums.Length <=1) return false;
        for(int i=0;i<nums.Length;i++){
            if(res.ContainsKey(nums[i])) return true;

            res[nums[i]] = 1;
        }
        return false;
    }
}