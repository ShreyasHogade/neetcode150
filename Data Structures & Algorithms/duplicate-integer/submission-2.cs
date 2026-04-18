public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> ifduplicate = new HashSet<int>(nums);
Console.WriteLine(ifduplicate.Count);
        return ifduplicate.Count < nums.Length;
    }
}