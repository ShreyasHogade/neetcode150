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
    public int MaxDepth(TreeNode root) {
        //using BFS - level First Traversal like for tree 
        // 1
       // / \
      // 2   3
      /// \
    //4   5  BFS will be 1 - 2 -3 - 4 -5 it uses queue to keep track of nodes to visit
    /* It uses a queue data structure to keep track of nodes to visit.
        Start by enqueuing the root node.
        While the queue is not empty:
        Dequeue a node.
        Visit it (e.g., print or process).
        Enqueue its children (left, then right). */

        Queue<TreeNode> q = new Queue<TreeNode>();

        if(root !=null){
            q.Enqueue(root);
        }

        int level = 0;
        while(q.Count >0){
            int size = q.Count;
            Console.WriteLine(size);

            for(int i = 0;i< size;i++){
                TreeNode node = q.Dequeue();

                if(node.left != null){
                    q.Enqueue(node.left);
                }

                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }

            level++;
        }
        return level;
    }
}
