using LeetCode.Solutions.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    class MergeTwoSortedLists : IOperation
    {
        //Merge two sorted linked lists and return it as a new list.
        //The new list should be made by splicing together the nodes of the first two lists.

        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(2);
            dataTypes.listNode.next.next = new ListNode(4);
            dataTypes.listNode.next.next.next = new ListNode(7);
            ListNode first = dataTypes.listNode;

            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(3);
            dataTypes.listNode.next.next = new ListNode(4);
            dataTypes.listNode.next.next.next = new ListNode(6);
            ListNode second = dataTypes.listNode;

            Print.printAllLinkedListNodes(MergeTwoLists(first, second));
        }

        private ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode output = new ListNode(0);
            ListNode persist = output;
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    output.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    output.next = l1;
                    l1 = l1.next;
                }
                output = output.next;
            }
            
            while (l1 != null)
            {
                output.next = l1;
                l1 = l1.next;
                output = output.next;
            }

            while (l2 != null)
            {
                output.next = l2;
                l2 = l2.next;
                output = output.next;
            }

            return persist.next;
        }
    }
}
