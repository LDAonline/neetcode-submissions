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
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null){
            return head;
        }
        var currentNode = head;
        var nextNode = currentNode.next;
        currentNode.next = null; // Only because not declared previous node yet
        var previousNode = currentNode;
        while (nextNode.next != null)
        {   
            currentNode = nextNode;
            nextNode = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
        }
        nextNode.next = previousNode;
        return nextNode;

    }
}
