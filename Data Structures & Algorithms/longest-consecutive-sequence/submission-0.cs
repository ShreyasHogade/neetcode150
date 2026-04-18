public class Solution {
    public int LongestConsecutive(int[] nums) {
        int maxCount = 1;
        int count = 1;

        Array.Sort(nums);
        if(nums.Length == 0) return 0;

//0 0 1 2 3 7 8 3
        for(int i = 1; i<nums.Length;i++){
            if(nums[i] == nums[i-1] ) continue; // skip duplicates
            
            if(nums[i] == nums[i-1]+1){
                count++;
            }else{
                maxCount = Math.Max(count,maxCount);
                count = 1;
            }
        }
        return Math.Max(maxCount,count);
    }
}
