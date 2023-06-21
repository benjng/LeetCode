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
        ListNode currentNode;
        ListNode head = new ListNode();
        currentNode = head;
        bool carry = false;

        while (l1 != null || l2 != null || carry != false){
            int _sum = 0;

            if (l1 != null){
                _sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null){
                _sum += l2.val;
                l2 = l2.next;
            }

            if (carry) {
                _sum++;
            }

            if (_sum >= 10) {
                _sum -= 10;
                carry = true;
            } else {
                carry = false;
            }

            currentNode.next = new ListNode(_sum);
            currentNode = currentNode.next;
        }
        return head.next;
    }
}