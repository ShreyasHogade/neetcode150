/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        List<int> arr = new List<int>();

        DFS(root,arr);

        arr.Sort();

        return arr[k-1];


    }

    private void DFS(TreeNode node, List<int> arr){
        if(node == null) return;
        arr.Add(node.val);

        DFS(node.left, arr);
        DFS(node.right, arr);
    }
}
