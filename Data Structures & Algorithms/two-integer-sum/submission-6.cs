public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> res = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int noToFind = target - nums[i];
            if(res.ContainsKey(noToFind))
            {
                return new int[]{res[noToFind],i};
            }
            res[nums[i]] = i;
        }
        return new int[]{};
    }
}
