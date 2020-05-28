using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    class PalindromeLinkedList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(2);
            dataTypes.listNode.next.next = new ListNode(2);
            dataTypes.listNode.next.next.next = new ListNode(2);
            System.Console.WriteLine(IsPalindrome(dataTypes.listNode));
        }

        // O(n) time with O(1) space method

        //reach to the middle of the linkedlist (Finding_Middle_Element_In_LinkedList)
        //and reverse the second half of the linkedlist and then compare with first half

        private bool IsPalindrome(ListNode head)
        {
            if (head?.next == null) return true;

            //calc middle element
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast != null)
            {
                // it means linked list is odd, no need to compare it
                ListNode middleElement = slow;
                slow = slow.next;
            }
            //Reverse the second part of linked list
            slow = Reverse(slow);

            while (slow != null)
            {
                if (head.val != slow.val)
                    return false;
                head = head.next;
                slow = slow.next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode previous = null, current = head;

            while (current != null)
            {
                var second = current.next;
                current.next = previous;
                previous = current;
                current = second;
            }

            head = previous;
            return head;
        }
    }
}
