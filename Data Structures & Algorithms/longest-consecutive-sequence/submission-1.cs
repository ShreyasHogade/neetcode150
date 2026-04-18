public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> numSet = new HashSet<int>(nums);

        int longest = 0;

        foreach(int num in nums){
            // 7 8 1 2 3 5 4 6 
            // we check only for forward sequence like lets say if we traverse
            // for 0th it will check if previous number is present if it is then 
            // it will skip for it so that sequence should shart with lowest number
            // in the sequence. 

            if(!numSet.Contains(num-1)) {
                int length = 1;

                while(numSet.Contains(num+length)){
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }
return longest;
    }
}
