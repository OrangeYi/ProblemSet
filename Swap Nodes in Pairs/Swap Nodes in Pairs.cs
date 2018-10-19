/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode temp = head;
        head = temp.next;
        ListNode lastNode = new ListNode(0);
        while(temp.next != null){
            ListNode tempNext = temp.next;
            if(tempNext == null) return head;
            lastNode.next = tempNext;
            temp.next = tempNext.next;
            tempNext.next = temp;
            lastNode = temp;
            temp = temp.next;
            if(temp == null) return head;
        }
        return head;
    }
}