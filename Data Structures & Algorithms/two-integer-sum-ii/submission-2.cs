public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int i=0;i<nums.Length;i++){
            int l = i+1,r=nums.Length -1;
            int tmp=target - nums[i];

            while(l<=r){
                int mid = l+ (r-l)/2;

                if(nums[mid]== tmp){
                    return new int[]{i+1,mid+1};
                }else if(nums[mid]>tmp){
                    r = mid-1;
                }else{
                    l = mid +1;
                }
            }
        }
        return new int[0];
    }
}
