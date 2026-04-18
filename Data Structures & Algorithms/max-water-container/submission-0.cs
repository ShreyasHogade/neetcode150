public class Solution {
    public int MaxArea(int[] heights) {
        
        int maxArea = int.MinValue;
        int area = int.MinValue;

        for(int i = 0;i< heights.Length;i++){

            for(int j=i+1;j<heights.Length;j++){
                area = Math.Min(heights[i], heights[j]) * (j - i);
                maxArea = Math.Max(area, maxArea);
            }
        }

    return maxArea;
    }
}
