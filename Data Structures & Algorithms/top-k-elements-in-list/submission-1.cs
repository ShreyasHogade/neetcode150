public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach(var n in nums){
            if(!count.ContainsKey(n)) count.Add(n,1);
            else
             count[n]++;
        }

        // use the priorityque which is min-heap(deque the least prior 
        //element i.e if values
        // 3 4 1 added then internally it will looks like 1 3 4 and will
        // deque 1 1st)

        var heap = new PriorityQueue<int, int>();
        foreach (var entry in count) {
            heap.Enqueue(entry.Key, entry.Value);
            if (heap.Count > k) {
                heap.Dequeue();
            }
        }

        var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = heap.Dequeue();
        }
        return res;


}
}
    

    
