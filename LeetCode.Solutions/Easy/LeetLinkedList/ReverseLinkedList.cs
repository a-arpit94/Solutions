using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    public class ReverseLinkedList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.pushNode(new ListNode(2));
            dataTypes.listNode.pushNode(new ListNode(3));
            dataTypes.listNode.pushNode(new ListNode(4));
            dataTypes.listNode.pushNode(new ListNode(5));
                
            //dataTypes.listNode.next = new ListNode(2);
            //dataTypes.listNode.next.next = new ListNode(3);
            //dataTypes.listNode.next.next.next = new ListNode(4);
            //dataTypes.listNode.next.next.next.next = new ListNode(5);
            Print.printAllLinkedListNodes(ReverseList(dataTypes.listNode));
        }

        public ListNode ReverseList(ListNode head)
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
