/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // HashSetで入れて、重複をチェックすることでCycleなのかを確認
        // LinkListがnullである場合まで確認
        HashSet<ListNode> hash = new HashSet<ListNode>();
        ListNode linkNode = head;
        
        while(linkNode != null){
            if(hash.Contains(linkNode) == true){
                return true;
            }

            hash.Add(linkNode);
            linkNode = linkNode.next;
            
        }
        return false; 
    }
}