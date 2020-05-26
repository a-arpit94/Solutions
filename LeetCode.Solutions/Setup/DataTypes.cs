namespace LeetCode.Solutions.Setup
{
    public class DataTypes
    {
        public int InputInt { get; set; }
        public int[] InputIntArray { get; set; }
        public string InputString { get; set; }
        public string[] InputStringArray { get; set; }
        public ListNode listNode { get; set; }
              
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode previous;
        public ListNode(int x) { val = x; }

        public void pushNode(ListNode node)
        {
            while (next != null)
                next = next.next;
            next = node;
        }
    }
}