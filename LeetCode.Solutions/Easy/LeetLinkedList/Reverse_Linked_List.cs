using LeetCode.Solutions.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    public class Reverse_Linked_List : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            //dataTypes.listNode.next = new ListNode(2);
            //dataTypes.listNode.next.next = new ListNode(3);
            //dataTypes.listNode.next.next.next = new ListNode(4);
            //dataTypes.listNode.next.next.next.next = new ListNode(5);
            Print.printAllLinkedListNodes(ReverseList(dataTypes.listNode));
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode first = head.next;
            if (first == null)
                return head;
            if (first.next == null)
            {
                first.next = head;
                head.next = null;
                return first;
            }
            else
            {
                while (head != null)
                {
                    head.next = head;
                }
            }
            return first;
        }
    }
}
