/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> previousNodes = new List<ListNode>();
        ListNode last = null;
        ListNode current = head;
        
        // check for special case
        if(current.next == null && n == 1)
            return current = null;
        
        previousNodes.Add(current);
        
        // look for last node, and add to our indexed list
        while(last == null) {
            
            current = current.next;
            previousNodes.Add(current);
            if(current.next == null) {
                last = current;
            }
        }
        
        // get the index of the node before the nth
        int index = previousNodes.Count-n-1; 
        
        // if the previous node doesn't exist, then return head's next
        if(index < 0) {
            return head.next;
        }
        
        // get the node previous to the nth
        ListNode nthPrev = previousNodes[index];
        
        // set pointers to remove the nth node
        nthPrev.next = nthPrev.next.next;
        
        return head;
    }
}
