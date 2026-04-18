public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums == null || nums.Length == 0) return 0;
        var hashMap = new HashSet<int>(nums);
        var result = 1;
        foreach(int i in hashMap){
            int length = 1;

            if(!hashMap.Contains(i-1)) {
                while(hashMap.Contains(i + length)) length++;

                result=Math.Max(length,result);
            }else{
            continue;
            }
        }

        return result;
    }
}
