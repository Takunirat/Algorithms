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

// We initialize two pointers: firstPointer and secondPointer. 
// 1. Here, the secondPointer is at the first node of the linked list, and the firstPointer is at the (N + 1)th node from the beginning.
// 2. Now, both pointers are separated by N nodes. We maintain this constant gap and advance both pointers together until the firstPointer reaches the last node.
// 3. The secondPointer will now point to the (N + 1)th node from the end. We can remove the Nth node from the list end by relinking the next pointer of the secondPointer to the next pointer of the next node.

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var first = head;
        var second = head;

        for(int i = 0; i < n; i++)
        {
            first = first.next;
        }

        // Тут надо удалить самый первый элемент списка.
        if(first == null)
        {
            return head.next;    
        }
        
        while(first.next != null)
        {
           first = first.next;
           second = second.next;
        }

        second.next = second.next.next;

        return head;
    }
}