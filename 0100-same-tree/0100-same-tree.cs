public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Queue<TreeNode> QueueP = new Queue<TreeNode>(); 
        Queue<TreeNode> QueueQ = new Queue<TreeNode>(); 

        QueueP.Enqueue(p);
        QueueQ.Enqueue(q);

        while(QueueP.Count > 0 && QueueQ.Count > 0)
        {
            TreeNode nodeP = QueueP.Dequeue();
            TreeNode nodeQ = QueueQ.Dequeue();

            if(nodeP == null && nodeQ == null){
                continue; 
            }
            else if(nodeP == null || nodeQ == null){
                return false;
            }
            else if(nodeP.val != nodeQ.val){
                return false;
            }

            QueueP.Enqueue(nodeP.left);
            QueueP.Enqueue(nodeP.right);

            QueueQ.Enqueue(nodeQ.left); 
            QueueQ.Enqueue(nodeQ.right);
            
        }

        return true; 
    }
}