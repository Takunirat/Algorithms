/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return AddTwoNumbers(l1, l2, false);
    }

    private ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool extra) {
        int sum = extra ? 1: 0;

        if(l1 == null && l2 == null)
        {
            if(extra)
            {
                return new ListNode(1, null);
            }

            return null;
        }
        
        if(l1 != null && l2 == null)
        {
            sum += l1.val;

            return new ListNode(sum % 10, AddTwoNumbers(l1.next, null, sum / 10 == 1));
        }

        if(l1 == null && l2 != null)
        {
            sum += l2.val;

            return new ListNode(sum % 10, AddTwoNumbers(null, l2.next, sum / 10 == 1));
        }

        sum += l1.val + l2.val;

        return new ListNode(sum % 10, AddTwoNumbers(l1.next, l2.next, sum / 10 == 1));
    }
}