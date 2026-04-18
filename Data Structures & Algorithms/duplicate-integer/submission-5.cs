public class Solution {
    public bool hasDuplicate(int[] nums) {
      if(nums == null || nums.Length <=1)
        return false;

        HashSet<int> seen = new();

        foreach(int num in nums){
            if(!seen.Add(num)) return true;

            seen.Add(num);
        }
      return false;
      
      /*  Dictionary<int,int> freq = new();
        if(nums.Length <=1) return false;
        for(int i=0;i<nums.Length;i++){
            if(freq.ContainsKey(nums[i])) return true;

            freq[nums[i]] = 1;
        }
        return false;*/
    }
}