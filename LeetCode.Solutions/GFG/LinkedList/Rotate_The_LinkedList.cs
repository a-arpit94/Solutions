using LeetCode.Solutions.Setup;

namespace LeetCode.Solutions.GFG.LinkedList
{
    class Rotate_The_LinkedList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(2);
            dataTypes.listNode.next.next = new ListNode(3);
            dataTypes.listNode.next.next.next = new ListNode(4);
            dataTypes.listNode.next.next.next.next = new ListNode(5);
            Print.printAllLinkedListNodes(RotateNode(dataTypes.listNode, 0));
        }

        private ListNode RotateNode(ListNode head, int rotatingIndex)
        {
            if (rotatingIndex == 0) return head;
            ListNode ptr = head;
            rotatingIndex--;
            while (head.next != null)
                head = head.next;
            head.next = ptr;
            while (rotatingIndex-- > 0)
            {
                ptr = ptr.next;
            }
            head = ptr.next;
            ptr.next = null;

            return head;
        }
    }
}
