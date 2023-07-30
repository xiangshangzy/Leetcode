/*
 * @lc app=leetcode.cn id=2 lang=csharp
 *
 * [2] 两数相加
 */

// @lc code=start
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
            ListNode head =new();
            ListNode p = head;
            int sum=0;
            while ( l1!= null || l2 != null)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;

                }
                p.next = new ListNode();
                p = p.next;
                p.val = sum % 10;
                sum /= 10;
            }

            if (sum > 0)
            {
                p.next = new ListNode();
                p = p.next;
                p.val = sum % 10;
            }
            return head.next;

    }
}
// @lc code=end

