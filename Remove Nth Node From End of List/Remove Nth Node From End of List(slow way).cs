
//Definition for singly-linked list.
// public class ListNode {
//      public int val;
//      public ListNode next;
//      public ListNode(int x) { val = x; }
//  }
 
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> allnode = new List<ListNode>{};
        ListNode temp = head;
        int index = 0;
        while(temp != null){
            allnode.Add(temp);
            temp = temp.next;
            index++;
        }
        int listlen = allnode.Count;
        int needremove = listlen - n;
        if(listlen == 1){//only have one element
            return null;
        }else if(listlen == 2 && n == 2){//only have tow element and remove first element
            allnode[0].next = null;
            return allnode[1];
        }else if(allnode.Count == n){//remove first one
            head = allnode[0].next;
            allnode[0].next = null;
            return head;
        }else if(n == 1){//remove last one
            allnode[index - 2].next = null;
            return head;
        }
        allnode[needremove - 1].next = allnode[needremove + 1];
        return head;
    }
}