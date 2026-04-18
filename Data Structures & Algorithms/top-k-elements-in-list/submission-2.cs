public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        
        foreach(int num in nums){
            if(count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }

        PriorityQueue<int, int> MinHeap = new PriorityQueue<int,int>();

        foreach(var i in count){
            MinHeap.Enqueue(i.Key, i.Value);
            if(MinHeap.Count > k) MinHeap.Dequeue();
        }

        var res = new int[k];
        for(int i=0;i<k;i++){
            res[i] = MinHeap.Dequeue();
        }

        return res;
    }
}
