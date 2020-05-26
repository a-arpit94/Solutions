using LeetCode.Solutions.Setup;
using System;

namespace LeetCode.Solutions.GFG.LinkedList
{
    class Finding_Middle_Element_In_LinkedList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            dataTypes.listNode = new ListNode(1);
            dataTypes.listNode.next = new ListNode(2);
            dataTypes.listNode.next.next = new ListNode(3);
            dataTypes.listNode.next.next.next = new ListNode(4);
            //dataTypes.listNode.next.next.next.next = new ListNode(5);

            Console.WriteLine(GetMiddle(dataTypes.listNode));
        }
        
        //Solving this by using two pointers, one increase by 1 unit and another increase by 2 units
        private int GetMiddle(ListNode listNode)
        {
            ListNode first = listNode, second = listNode;
            while(second != null && second.next != null)
            {
                first = first.next;
                second = second.next.next;
            }
            return first.val;
        }
    }
}
