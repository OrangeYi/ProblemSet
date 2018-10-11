/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        else if(l2 == null) return l1;
        
        ListNode result;
        if(l1.val < l2.val){
            result = new ListNode(l1.val);
            l1 = l1.next;
        }else{
            result = new ListNode(l2.val);
            l2 = l2.next;
        }
        ListNode pointer = result;
        while(l1 != null || l2 != null){
            if(l1 == null){
                pointer.next = l2;
                break;
            }else if(l2 == null){
                pointer.next = l1;
                break;
            }
            int l1int = l1.val;
            int l2int = l2.val;
            if(l1int < l2int){
                ListNode newnode = new ListNode(l1.val);
                pointer.next = newnode;
                pointer = newnode;
                l1 = l1.next;
            }else{
                ListNode newnode = new ListNode(l2.val);
                pointer.next = newnode;
                pointer = newnode;
                l2 = l2.next;
            }
        }
        return result;
    }
}