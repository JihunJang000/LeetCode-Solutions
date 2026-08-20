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
    public bool IsSymmetric(TreeNode root) {
        // stackを2個使用。 Root Nodeの子2個をLeftStack, RightStackで分けて、
        // Leftはleftを先に入れて、Rightはrightを先に入れる事で対称的に処理可能。
        // 各対称的な関係を比較する時は、2個が同じくnull, 1個がnull、2個が同じくnullじゃない場合に
        // 分けて比較。

        Stack<TreeNode> leftStack = new Stack<TreeNode>();
        Stack<TreeNode> rightStack= new Stack<TreeNode>();

        leftStack.Push(root.left);
        rightStack.Push(root.right);

        while(leftStack.Count > 0 || rightStack.Count > 0){
            TreeNode leftSideNode =leftStack.Pop();
            TreeNode rightSideNode =rightStack.Pop();

            // popした値を比較。
            if(leftSideNode == null && rightSideNode == null){
                continue;
            }
            // 1個がnullである場合。 return false; 
            else if(leftSideNode == null || rightSideNode == null){
                return false;
            }
            else{
                if(leftSideNode.val != rightSideNode.val){
                    return false;
                }
            }

            leftStack.Push(leftSideNode.left);
            leftStack.Push(leftSideNode.right);

            rightStack.Push(rightSideNode.right);
            rightStack.Push(rightSideNode.left);
        }


        return true; 



    }
}