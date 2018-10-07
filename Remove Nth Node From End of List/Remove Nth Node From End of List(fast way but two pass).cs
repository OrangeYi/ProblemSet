
//Definition for singly-linked list.
// public class ListNode {
//      public int val;
//      public ListNode next;
//      public ListNode(int x) { val = x; }
//  }
 
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode start = new ListNode(0);
        ListNode fast = start;
        ListNode slow = start;
        slow.next = head;
        for(int i = 0 ; i <= n; ++i){
            fast = fast.next;
        }
        while(fast != null){
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return start.next;
    }
}