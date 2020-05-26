using LeetCode.Solutions.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    class Remove_Nth_Node_From_End_of_List : IOperation
    {
        /*Given linked list: 1->2->3->4->5, and n = 2.
        After removing the second node from the end, the linked list becomes 1->2->3->5.
         */

        /*Solution : The above algorithm could be optimized to one pass. 
         * Instead of one pointer, we could use two pointers. 
         * The first pointer advances the list by n+1n+1 steps from the beginning, 
         * while the second pointer starts from the beginning of the list. 
         * Now, both pointers are exactly separated by nn nodes apart. 
         * We maintain this constant gap by advancing both pointers together until the first pointer arrives past the last node. 
         * The second pointer will be pointing at the nnth node counting from the last. 
         * We relink the next pointer of the node referenced by the second pointer to point to the node's next next node.*/
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(2);
            dataTypes.listNode.next.next = new ListNode(3);
            dataTypes.listNode.next.next.next = new ListNode(4);
            dataTypes.listNode.next.next.next.next = new ListNode(5);

            Print.printAllLinkedListNodes(RemoveNthFromEnd(dataTypes.listNode, 5));
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for (int i = 0; i <= n; i++)
                first = first.next;

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;
        }
    }
}
