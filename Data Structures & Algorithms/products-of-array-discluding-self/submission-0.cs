public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int res = 1, zerocount = 0;
        int[] resArr = new int[nums.Length];

        foreach(int i in nums){
            if(i !=0)res *= i;
            else zerocount++;
        }
        //if zero count > 1 then all product of the other digits will be 0.

        if(zerocount >1){
            Console.WriteLine(zerocount);
            return new int[nums.Length];
        }

        Console.WriteLine(res);
        for(int i =0;i<nums.Length;i++){
            Console.WriteLine(res+" "+nums.Length+""+zerocount);
            if(zerocount>0){ resArr[i] = (nums[i] == 0) ? res: 0;}
            else resArr[i] = res/nums[i];

            Console.WriteLine(resArr[i]);
        }
return resArr;

    }
}
