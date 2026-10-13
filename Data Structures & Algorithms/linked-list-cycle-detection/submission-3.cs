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
    public bool HasCycle(ListNode head) {
       var counter = 0;
       if (head == null){
            return false;
       }
       var currentNode = head;
       if (head.next == null){
        return false;
       }
       var nextNode = head.next;
       while(nextNode.next != null){
            counter++;
            currentNode = currentNode.next;
            for (var i = 0; i < counter; i++)
            {
                nextNode = nextNode.next;
                if (nextNode == currentNode){
                    return true;
                }
            }
       } 
       return false;
    }
}
