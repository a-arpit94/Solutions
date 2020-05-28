using Common.Setup;

namespace LeetCode.Solutions.Easy.LeetLinkedList
{
    public class DeleteNodeInALinkedList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(4);
            dataTypes.listNode.next = new ListNode(5);
            dataTypes.listNode.next.next = new ListNode(1);
            dataTypes.listNode.next.next.next = new ListNode(9);

            //Send the node you want to delete and not all linked list --> **tricky part
            DeleteNode(dataTypes.listNode.next);
            //Output should be 4->1->9
            Print.printAllLinkedListNodes(dataTypes.listNode);
        }

        /*
         * Since we do not have access to the node before the one we want to delete, 
         * we cannot modify the next pointer of that node in any way. 
         * Instead, we have to replace the value of the node we want to delete with the value in the node after it, 
         * and then delete the node after it.
         */
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
