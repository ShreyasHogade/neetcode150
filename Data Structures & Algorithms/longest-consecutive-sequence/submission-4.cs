public class Solution {
    public int LongestConsecutive(int[] nums) {
        // 1 1 2 4 3 4
        // 1 1 2 3 4 4
        if(nums == null || nums.Length == 0 ) return 0;
        int lngst = int.MinValue;   

        Array.Sort(nums);
        int series = 1;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i] == nums[i+1]) continue;

            if(nums[i+1] == nums[i]+1) { 
                series++;
            }else{
                lngst = Math.Max(series, lngst);
                series = 1;
            }

        }
        return Math.Max(lngst, series);
    }
}
