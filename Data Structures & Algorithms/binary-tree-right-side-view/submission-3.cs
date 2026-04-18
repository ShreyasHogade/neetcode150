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
    
public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        DFS(root, 0, res);
        return res;
    }

    private void DFS(TreeNode node, int depth, List<int> res) {
        if (node == null) return;

        // If this is the first time we're visiting this depth
        if (depth == res.Count) {
            res.Add(node.val);
        }

        // Traverse right first, then left
        DFS(node.right, depth + 1, res);
        DFS(node.left, depth + 1, res);
    }
}
